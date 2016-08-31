﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using ETUDriver;

namespace GazeNetClient
{
    public class GazeNetClient : IDisposable
    {
        public enum TrackingState
        {
            NotAvailable,
            Disconnected,
            Connected,
            Calibrating,
            Calibrated,
            Tracking
        }

        #region Internal members

        private CoETUDriver iETUDriver = null;
        private Processor.GazeParser iGazeParser = null;
        private Pointer.Collection iPointers = new Pointer.Collection();
        private Menu iMenu = null;
        private Options iOptions = null;
        private NotifyIcon iTrayIcon = null;

        private WebSocket.Client iWebSocketClient = null;
        private SynchronizationContext iUIContext;

        private bool iExitAfterTrackingStopped = false;
        private bool iDisposed = false;

        #endregion

        #region Properties

        public AutoStarter AutoStarter { get; private set; }
        public TrackingState State
        {
            get
            {
                GazeNetClient.TrackingState result = TrackingState.NotAvailable;
                if (iETUDriver.Active != 0)
                    result = GazeNetClient.TrackingState.Tracking;
                else if (iETUDriver.Calibrated != 0)
                    result = GazeNetClient.TrackingState.Calibrated;
                else switch (iETUDriver.Ready)
                    {
                        case 1: result = GazeNetClient.TrackingState.Disconnected; break;
                        case 2: result = GazeNetClient.TrackingState.Connected; break;
                        case 3: result = GazeNetClient.TrackingState.Calibrating; break;
                    }
                return result;
            }
        }

        #endregion

        #region Public methods

        public GazeNetClient()
        {
            AutoStarter = Utils.Storage<AutoStarter>.load();

            iETUDriver = new CoETUDriver();
            iETUDriver.OptionsFile = Utils.Storage.Folder + "etudriver.ini";
            iETUDriver.OnRecordingStart += ETUDriver_OnRecordingStart;
            iETUDriver.OnRecordingStop += ETUDriver_OnRecordingStop;
            iETUDriver.OnCalibrated += ETUDriver_OnCalibrated;
            iETUDriver.OnDataEvent += ETUDriver_OnDataEvent;

            iGazeParser = new Processor.GazeParser();
            iGazeParser.OnNewGazePoint += GazeParser_OnNewGazePoint;

            iWebSocketClient = new WebSocket.Client(WebSocket.Config.Default);
            iWebSocketClient.OnSample += WebSocketClient_OnSample;
            iWebSocketClient.OnClosed += WebSocketClient_OnClosed;

            iMenu = new Menu();
            iMenu.OnShowOptions += showOptions;
            iMenu.OnToggleVisibility += toggleVisibility;
            iMenu.OnShowETUDOptions += showETUDOptions;
            iMenu.OnCalibrate += calibrate;
            iMenu.OnToggleTracking += toggleTracking;
            iMenu.OnExit += Menu_Exit;

            iOptions = new Options();

            iUIContext = System.Windows.Forms.WindowsFormsSynchronizationContext.Current;
            if (iUIContext == null)
            {
                Console.WriteLine(" --- no context --- ");
            }

            iTrayIcon = new NotifyIcon();
            iTrayIcon.Icon = Icon.FromHandle(new Bitmap(iOptions.Icons["icon"]).GetHicon());
            iTrayIcon.ContextMenuStrip = iMenu.Strip;
            iTrayIcon.Text = "GazeNet client";
            iTrayIcon.Visible = true;

            Utils.GlobalShortcut.add(new Utils.Shortcut("Pointer", new Action(toggleVisibility), Keys.Pause));
            Utils.GlobalShortcut.add(new Utils.Shortcut("Tracking", new Action(Shortcut_TrackingNext), Keys.PrintScreen, Keys.Control));
            Utils.GlobalShortcut.init();

            UpdateMenu(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void showOptions()
        {
            UpdateMenu(true);
            iOptions.load(iPointers, iGazeParser.Filter, AutoStarter, iWebSocketClient);
            bool acceptChanges = iOptions.ShowDialog() == DialogResult.OK;
            iOptions.save(acceptChanges);

            UpdateMenu(false);
        }

        public void toggleVisibility()
        {
            iPointers.Visible = !iPointers.Visible;
        }

        public void showETUDOptions()
        {
            UpdateMenu(true);
            iETUDriver.showRecordingOptions();
            UpdateMenu(false);
        }

        public void calibrate()
        {
            UpdateMenu(true);
            iETUDriver.calibrate();
            UpdateMenu(false);
        }

        public void toggleTracking()
        {
            if (iETUDriver.Active == 0)
            {
                Pointer.Collection.VisilityFollowsDataAvailability = true;
                iGazeParser.start();
                iETUDriver.startTracking();
            }
            else
            {
                iETUDriver.stopTracking();
                iGazeParser.stop();
                Pointer.Collection.VisilityFollowsDataAvailability = false;
            }
        }

        #endregion

        #region Internal methods

        protected virtual void Dispose(bool aDisposing)
        {
            if (iDisposed)
                return;

            if (aDisposing)
            {
                // Free any other managed objects here.
                iGazeParser.Dispose();
                iPointers.Dispose();

                if (iWebSocketClient != null)
                    iWebSocketClient.Dispose();

                Utils.Storage<AutoStarter>.save(AutoStarter);
                Utils.GlobalShortcut.close();
            }

            // Free any unmanaged objects here.
            iETUDriver = null;
            
            iDisposed = true;
        }

        private void UpdateMenu(bool aIsShowingDialog)
        {
            Menu.State trackerState = new Menu.State();
            trackerState.IsShowingOptions = aIsShowingDialog;
            trackerState.IsVisible = iPointers.Visible;
            trackerState.HasDevices = iETUDriver != null && iETUDriver.DeviceCount > 0;
            trackerState.IsConnected = iETUDriver != null && iETUDriver.Ready != 0;
            trackerState.IsCalibrated = iETUDriver != null && iETUDriver.Calibrated != 0;
            trackerState.IsTracking = iETUDriver != null && iETUDriver.Active != 0;
            iMenu.update(trackerState);
        }

        private void Exit()
        {
            iTrayIcon.Visible = false;
            Application.Exit();
        }

        #endregion

        #region ETUD event handlers

        private void ETUDriver_OnCalibrated()
        {
            UpdateMenu(false);
        }

        private void ETUDriver_OnRecordingStart()
        {
            iTrayIcon.Icon = Icon.FromHandle(new Bitmap(iOptions.Icons["icon-active"]).GetHicon());
            UpdateMenu(false);
        }

        private void ETUDriver_OnRecordingStop()
        {
            iTrayIcon.Icon = Icon.FromHandle(new Bitmap(iOptions.Icons["icon"]).GetHicon());
            UpdateMenu(false);

            if (iExitAfterTrackingStopped)
            {
                Exit();
            }
        }

        private void ETUDriver_OnDataEvent(EiETUDGazeEvent aEventID, ref int aData, ref int aResult)
        {
            if (aEventID == EiETUDGazeEvent.geSample)
            {
                SiETUDSample smp = iETUDriver.LastSample;
                PointF gazePoint = new PointF(smp.X[0], smp.Y[0]);
                iGazeParser.feed(smp.Time, gazePoint);
            }
        }

        #endregion

        #region Other event handlers

        private void Menu_Exit()
        {
            if (iETUDriver != null && iETUDriver.Active != 0)
            {
                iExitAfterTrackingStopped = true;
                iETUDriver.stopTracking();
            }
            else
            {
                Exit();
            }
        }

        private void WebSocketClient_OnSample(object aSender, WebSocket.GazeEventReceived aArgs)
        {
            //iPointers.feed(aArgs);
            iUIContext.Send(new SendOrPostCallback((target) => {
                iPointers.MovePointer(aArgs.from, aArgs.payload.Location);
            }), null);
        }

        private void WebSocketClient_OnClosed(object sender, EventArgs e)
        {
            // do nothing
        }

        private void GazeParser_OnNewGazePoint(object aSender, Processor.GazeParser.NewGazePointArgs aArgs)
        {
            iWebSocketClient.send(new WebSocket.GazeEvent(aArgs.Location));
        }

        private void Shortcut_TrackingNext()
        {
            if (State == TrackingState.Disconnected)
                showETUDOptions();
            else if (State == TrackingState.Connected)
                calibrate();
            else if (State == TrackingState.Calibrated)
                toggleTracking();
            else if (State == TrackingState.Tracking)
                toggleTracking();
        }

        #endregion
    }
}
