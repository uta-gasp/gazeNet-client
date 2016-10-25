﻿using System;
using System.Runtime.InteropServices;

namespace GazeNetClient.Utils
{
    public static class WinAPI
    {
        public static class VK
        {
            public static readonly uint
                LBUTTON = 0x01,
                RBUTTON = 0x02,
                CANCEL = 0x03,
                MBUTTON = 0x04,
                XBUTTON1 = 0x05,
                XBUTTON2 = 0x06,
                BACK = 0x08,
                TAB = 0x09,
                CLEAR = 0x0C,
                RETURN = 0x0D,
                SHIFT = 0x10,
                CONTROL = 0x11,
                MENU = 0x12,
                PAUSE = 0x13,
                CAPITAL = 0x14,
                KANA = 0x15,
                HANGUEL = 0x15,
                HANGUL = 0x15,
                JUNJA = 0x17,
                FINAL = 0x18,
                HANJA = 0x19,
                KANJI = 0x19,
                ESCAPE = 0x1B,
                CONVERT = 0x1C,
                NONCONVERT = 0x1D,
                ACCEPT = 0x1E,
                MODECHANGE = 0x1F,
                SPACE = 0x20,
                PRIOR = 0x21,
                NEXT = 0x22,
                END = 0x23,
                HOME = 0x24,
                LEFT = 0x25,
                UP = 0x26,
                RIGHT = 0x27,
                DOWN = 0x28,
                SELECT = 0x29,
                PRINT = 0x2A,
                EXECUTE = 0x2B,
                SNAPSHOT = 0x2C,
                INSERT = 0x2D,
                DELETE = 0x2E,
                HELP = 0x2F,
                N0 = 0x30,
                N1 = 0x31,
                N2 = 0x32,
                N3 = 0x33,
                N4 = 0x34,
                N5 = 0x35,
                N6 = 0x36,
                N7 = 0x37,
                N8 = 0x38,
                N9 = 0x39,
                A = 0x41,
                B = 0x42,
                C = 0x43,
                D = 0x44,
                E = 0x45,
                F = 0x46,
                G = 0x47,
                H = 0x48,
                I = 0x49,
                J = 0x4A,
                K = 0x4B,
                L = 0x4C,
                M = 0x4D,
                N = 0x4E,
                O = 0x4F,
                P = 0x50,
                Q = 0x51,
                R = 0x52,
                S = 0x53,
                T = 0x54,
                U = 0x55,
                V = 0x56,
                W = 0x57,
                X = 0x58,
                Y = 0x59,
                Z = 0x5A,
                LWIN = 0x5B,
                RWIN = 0x5C,
                APPS = 0x5D,
                SLEEP = 0x5F,
                NUMPAD0 = 0x60,
                NUMPAD1 = 0x61,
                NUMPAD2 = 0x62,
                NUMPAD3 = 0x63,
                NUMPAD4 = 0x64,
                NUMPAD5 = 0x65,
                NUMPAD6 = 0x66,
                NUMPAD7 = 0x67,
                NUMPAD8 = 0x68,
                NUMPAD9 = 0x69,
                MULTIPLY = 0x6A,
                ADD = 0x6B,
                SEPARATOR = 0x6C,
                SUBTRACT = 0x6D,
                DECIMAL = 0x6E,
                DIVIDE = 0x6F,
                F1 = 0x70,
                F2 = 0x71,
                F3 = 0x72,
                F4 = 0x73,
                F5 = 0x74,
                F6 = 0x75,
                F7 = 0x76,
                F8 = 0x77,
                F9 = 0x78,
                F10 = 0x79,
                F11 = 0x7A,
                F12 = 0x7B,
                F13 = 0x7C,
                F14 = 0x7D,
                F15 = 0x7E,
                F16 = 0x7F,
                F17 = 0x80,
                F18 = 0x81,
                F19 = 0x82,
                F20 = 0x83,
                F21 = 0x84,
                F22 = 0x85,
                F23 = 0x86,
                F24 = 0x87,
                NUMLOCK = 0x90,
                SCROLL = 0x91,
                LSHIFT = 0xA0,
                RSHIFT = 0xA1,
                LCONTROL = 0xA2,
                RCONTROL = 0xA3,
                LMENU = 0xA4,
                RMENU = 0xA5,
                BROWSER_BACK = 0xA6,
                BROWSER_FORWARD = 0xA7,
                BROWSER_REFRESH = 0xA8,
                BROWSER_STOP = 0xA9,
                BROWSER_SEARCH = 0xAA,
                BROWSER_FAVORITES = 0xAB,
                BROWSER_HOME = 0xAC,
                VOLUME_MUTE = 0xAD,
                VOLUME_DOWN = 0xAE,
                VOLUME_UP = 0xAF,
                MEDIA_NEXT_TRACK = 0xB0,
                MEDIA_PREV_TRACK = 0xB1,
                MEDIA_STOP = 0xB2,
                MEDIA_PLAY_PAUSE = 0xB3,
                LAUNCH_MAIL = 0xB4,
                LAUNCH_MEDIA_SELECT = 0xB5,
                LAUNCH_APP1 = 0xB6,
                LAUNCH_APP2 = 0xB7,
                OEM_1 = 0xBA,
                OEM_PLUS = 0xBB,
                OEM_COMMA = 0xBC,
                OEM_MINUS = 0xBD,
                OEM_PERIOD = 0xBE,
                OEM_2 = 0xBF,
                OEM_3 = 0xC0,
                OEM_4 = 0xDB,
                OEM_5 = 0xDC,
                OEM_6 = 0xDD,
                OEM_7 = 0xDE,
                OEM_8 = 0xDF,
                OEM_102 = 0xE2,
                PROCESSKEY = 0xE5,
                PACKET = 0xE7,
                ATTN = 0xF6,
                CRSEL = 0xF7,
                EXSEL = 0xF8,
                EREOF = 0xF9,
                PLAY = 0xFA,
                ZOOM = 0xFB,
                PA1 = 0xFD,
                OEM_CLEAR = 0xFE;
        }

        public static class WM
        {
            public static readonly uint
                NULL = 0x0000,
                CREATE = 0x0001,
                DESTROY = 0x0002,
                MOVE = 0x0003,
                SIZE = 0x0005,
                ACTIVATE = 0x0006,
                SETFOCUS = 0x0007,
                KILLFOCUS = 0x0008,
                ENABLE = 0x000A,
                SETREDRAW = 0x000B,
                SETTEXT = 0x000C,
                GETTEXT = 0x000D,
                GETTEXTLENGTH = 0x000E,
                PAINT = 0x000F,
                CLOSE = 0x0010,
                QUERYENDSESSION = 0x0011,
                QUERYOPEN = 0x0013,
                ENDSESSION = 0x0016,
                QUIT = 0x0012,
                ERASEBKGND = 0x0014,
                SYSCOLORCHANGE = 0x0015,
                SHOWWINDOW = 0x0018,
                WININICHANGE = 0x001A,
                SETTINGCHANGE = WININICHANGE,
                DEVMODECHANGE = 0x001B,
                ACTIVATEAPP = 0x001C,
                FONTCHANGE = 0x001D,
                TIMECHANGE = 0x001E,
                CANCELMODE = 0x001F,
                SETCURSOR = 0x0020,
                MOUSEACTIVATE = 0x0021,
                CHILDACTIVATE = 0x0022,
                QUEUESYNC = 0x0023,
                GETMINMAXINFO = 0x0024,
                PAINTICON = 0x0026,
                ICONERASEBKGND = 0x0027,
                NEXTDLGCTL = 0x0028,
                SPOOLERSTATUS = 0x002A,
                DRAWITEM = 0x002B,
                MEASUREITEM = 0x002C,
                DELETEITEM = 0x002D,
                VKEYTOITEM = 0x002E,
                CHARTOITEM = 0x002F,
                SETFONT = 0x0030,
                GETFONT = 0x0031,
                SETHOTKEY = 0x0032,
                GETHOTKEY = 0x0033,
                QUERYDRAGICON = 0x0037,
                COMPAREITEM = 0x0039,
                GETOBJECT = 0x003D,
                COMPACTING = 0x0041,
                COMMNOTIFY = 0x0044,
                WINDOWPOSCHANGING = 0x0046,
                WINDOWPOSCHANGED = 0x0047,
                POWER = 0x0048,
                COPYDATA = 0x004A,
                CANCELJOURNAL = 0x004B,
                NOTIFY = 0x004E,
                INPUTLANGCHANGEREQUEST = 0x0050,
                INPUTLANGCHANGE = 0x0051,
                TCARD = 0x0052,
                HELP = 0x0053,
                USERCHANGED = 0x0054,
                NOTIFYFORMAT = 0x0055,
                CONTEXTMENU = 0x007B,
                STYLECHANGING = 0x007C,
                STYLECHANGED = 0x007D,
                DISPLAYCHANGE = 0x007E,
                GETICON = 0x007F,
                SETICON = 0x0080,
                NCCREATE = 0x0081,
                NCDESTROY = 0x0082,
                NCCALCSIZE = 0x0083,
                NCHITTEST = 0x0084,
                NCPAINT = 0x0085,
                NCACTIVATE = 0x0086,
                GETDLGCODE = 0x0087,
                SYNCPAINT = 0x0088,
                NCMOUSEMOVE = 0x00A0,
                NCLBUTTONDOWN = 0x00A1,
                NCLBUTTONUP = 0x00A2,
                NCLBUTTONDBLCLK = 0x00A3,
                NCRBUTTONDOWN = 0x00A4,
                NCRBUTTONUP = 0x00A5,
                NCRBUTTONDBLCLK = 0x00A6,
                NCMBUTTONDOWN = 0x00A7,
                NCMBUTTONUP = 0x00A8,
                NCMBUTTONDBLCLK = 0x00A9,
                NCXBUTTONDOWN = 0x00AB,
                NCXBUTTONUP = 0x00AC,
                NCXBUTTONDBLCLK = 0x00AD,
                INPUT_DEVICE_CHANGE = 0x00FE,
                INPUT = 0x00FF,
                KEYFIRST = 0x0100,
                KEYDOWN = 0x0100,
                KEYUP = 0x0101,
                CHAR = 0x0102,
                DEADCHAR = 0x0103,
                SYSKEYDOWN = 0x0104,
                SYSKEYUP = 0x0105,
                SYSCHAR = 0x0106,
                SYSDEADCHAR = 0x0107,
                UNICHAR = 0x0109,
                KEYLAST = 0x0109,
                IME_STARTCOMPOSITION = 0x010D,
                IME_ENDCOMPOSITION = 0x010E,
                IME_COMPOSITION = 0x010F,
                IME_KEYLAST = 0x010F,
                INITDIALOG = 0x0110,
                COMMAND = 0x0111,
                SYSCOMMAND = 0x0112,
                TIMER = 0x0113,
                HSCROLL = 0x0114,
                VSCROLL = 0x0115,
                INITMENU = 0x0116,
                INITMENUPOPUP = 0x0117,
                MENUSELECT = 0x011F,
                MENUCHAR = 0x0120,
                ENTERIDLE = 0x0121,
                MENURBUTTONUP = 0x0122,
                MENUDRAG = 0x0123,
                MENUGETOBJECT = 0x0124,
                UNINITMENUPOPUP = 0x0125,
                MENUCOMMAND = 0x0126,
                CHANGEUISTATE = 0x0127,
                UPDATEUISTATE = 0x0128,
                QUERYUISTATE = 0x0129,
                CTLCOLORMSGBOX = 0x0132,
                CTLCOLOREDIT = 0x0133,
                CTLCOLORLISTBOX = 0x0134,
                CTLCOLORBTN = 0x0135,
                CTLCOLORDLG = 0x0136,
                CTLCOLORSCROLLBAR = 0x0137,
                CTLCOLORSTATIC = 0x0138,
                MOUSEFIRST = 0x0200,
                MOUSEMOVE = 0x0200,
                LBUTTONDOWN = 0x0201,
                LBUTTONUP = 0x0202,
                LBUTTONDBLCLK = 0x0203,
                RBUTTONDOWN = 0x0204,
                RBUTTONUP = 0x0205,
                RBUTTONDBLCLK = 0x0206,
                MBUTTONDOWN = 0x0207,
                MBUTTONUP = 0x0208,
                MBUTTONDBLCLK = 0x0209,
                MOUSEWHEEL = 0x020A,
                XBUTTONDOWN = 0x020B,
                XBUTTONUP = 0x020C,
                XBUTTONDBLCLK = 0x020D,
                MOUSEHWHEEL = 0x020E,
                MOUSELAST = 0x020E,
                PARENTNOTIFY = 0x0210,
                ENTERMENULOOP = 0x0211,
                EXITMENULOOP = 0x0212,
                NEXTMENU = 0x0213,
                SIZING = 0x0214,
                CAPTURECHANGED = 0x0215,
                MOVING = 0x0216,
                POWERBROADCAST = 0x0218,
                DEVICECHANGE = 0x0219,
                MDICREATE = 0x0220,
                MDIDESTROY = 0x0221,
                MDIACTIVATE = 0x0222,
                MDIRESTORE = 0x0223,
                MDINEXT = 0x0224,
                MDIMAXIMIZE = 0x0225,
                MDITILE = 0x0226,
                MDICASCADE = 0x0227,
                MDIICONARRANGE = 0x0228,
                MDIGETACTIVE = 0x0229,
                MDISETMENU = 0x0230,
                ENTERSIZEMOVE = 0x0231,
                EXITSIZEMOVE = 0x0232,
                DROPFILES = 0x0233,
                MDIREFRESHMENU = 0x0234,
                IME_SETCONTEXT = 0x0281,
                IME_NOTIFY = 0x0282,
                IME_CONTROL = 0x0283,
                IME_COMPOSITIONFULL = 0x0284,
                IME_SELECT = 0x0285,
                IME_CHAR = 0x0286,
                IME_REQUEST = 0x0288,
                IME_KEYDOWN = 0x0290,
                IME_KEYUP = 0x0291,
                MOUSEHOVER = 0x02A1,
                MOUSELEAVE = 0x02A3,
                NCMOUSEHOVER = 0x02A0,
                NCMOUSELEAVE = 0x02A2,
                WTSSESSION_CHANGE = 0x02B1,
                TABLET_FIRST = 0x02c0,
                TABLET_LAST = 0x02df,
                CUT = 0x0300,
                COPY = 0x0301,
                PASTE = 0x0302,
                CLEAR = 0x0303,
                UNDO = 0x0304,
                RENDERFORMAT = 0x0305,
                RENDERALLFORMATS = 0x0306,
                DESTROYCLIPBOARD = 0x0307,
                DRAWCLIPBOARD = 0x0308,
                PAINTCLIPBOARD = 0x0309,
                VSCROLLCLIPBOARD = 0x030A,
                SIZECLIPBOARD = 0x030B,
                ASKCBFORMATNAME = 0x030C,
                CHANGECBCHAIN = 0x030D,
                HSCROLLCLIPBOARD = 0x030E,
                QUERYNEWPALETTE = 0x030F,
                PALETTEISCHANGING = 0x0310,
                PALETTECHANGED = 0x0311,
                HOTKEY = 0x0312,
                PRINT = 0x0317,
                PRINTCLIENT = 0x0318,
                APPCOMMAND = 0x0319,
                THEMECHANGED = 0x031A,
                CLIPBOARDUPDATE = 0x031D,
                DWMCOMPOSITIONCHANGED = 0x031E,
                DWMNCRENDERINGCHANGED = 0x031F,
                DWMCOLORIZATIONCOLORCHANGED = 0x0320,
                DWMWINDOWMAXIMIZEDCHANGE = 0x0321,
                GETTITLEBARINFOEX = 0x033F,
                HANDHELDFIRST = 0x0358,
                HANDHELDLAST = 0x035F,
                AFXFIRST = 0x0360,
                AFXLAST = 0x037F,
                PENWINFIRST = 0x0380,
                PENWINLAST = 0x038F,
                APP = 0x8000,
                USER = 0x0400,

                CPL_LAUNCH = USER + 0x1000,
                CPL_LAUNCHED = USER + 0x1001,
                SYSTIMER = 0x118;
        }

        public static class WS_EX
        {
            public static readonly int
                ACCEPTFILES = 0x00000010,
                APPWINDOW = 0x00040000,
                CLIENTEDGE = 0x00000200,
                COMPOSITED = 0x02000000,
                CONTEXTHELP = 0x00000400,
                CONTROLPARENT = 0x00010000,
                DLGMODALFRAME = 0x00000001,
                LAYERED = 0x00080000,
                LAYOUTRTL = 0x00400000,
                LEFT = 0x00000000,
                LEFTSCROLLBAR = 0x00004000,
                LTRREADING = 0x00000000,
                MDICHILD = 0x00000040,
                NOACTIVATE = 0x08000000,
                NOINHERITLAYOUT = 0x00100000,
                NOPARENTNOTIFY = 0x00000004,
                OVERLAPPEDWINDOW = WINDOWEDGE | CLIENTEDGE,
                PALETTEWINDOW = WINDOWEDGE | TOOLWINDOW | TOPMOST,
                RIGHT = 0x00001000,
                RIGHTSCROLLBAR = 0x00000000,
                RTLREADING = 0x00002000,
                STATICEDGE = 0x00020000,
                TOOLWINDOW = 0x00000080,
                TOPMOST = 0x00000008,
                TRANSPARENT = 0x00000020,
                WINDOWEDGE = 0x00000100;
        }

        public static class HT
        {
            public static readonly int
                ERROR = -2,
                TRANSPARENT = -1,
                NOWHERE = 0,
                CLIENT = 1,
                CAPTION = 2,
                SYSMENU = 3,
                GROWBOX = 4,
                MENU = 5,
                HSCROLL = 6,
                VSCROLL = 7,
                MINBUTTON = 8,
                MAXBUTTON = 9,
                LEFT = 10,
                RIGHT = 11,
                TOP = 12,
                TOPLEFT = 13,
                TOPRIGHT = 14,
                BOTTOM = 15,
                BOTTOMLEFT = 16,
                BOTTOMRIGHT = 17,
                BORDER = 18,
                OBJECT = 19,
                CLOSE = 20,
                HELP = 21;
        }

        public static class GCL
        {
            public static readonly int
                MENUNAME = -8,
                HBRBACKGROUND = -10,
                HCURSOR = -12,
                HICON = -14,
                HMODULE = -16,
                CBWNDEXTRA = -18,
                CBCLSEXTRA = -20,
                WNDPROC = -24,
                STYLE = -26,
                HICONSM = -34,
                ATOM = -32;
        }

        public static class IDI
        {
            public static readonly int
                APPLICATION = 32512,
                HAND = 32513,
                QUESTION = 32514,
                EXCLAMATION = 32515,
                ASTERISK = 32516,
                WINLOGO = 32517,
                WARNING = EXCLAMATION,
                ERROR = HAND,
                INFORMATION = ASTERISK;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWINFO
        {
            public uint cbSize;
            public RECT rcWindow;
            public RECT rcClient;
            public uint dwStyle;
            public uint dwExStyle;
            public uint dwWindowStatus;
            public uint cxWindowBorders;
            public uint cyWindowBorders;
            public ushort atomWindowType;
            public ushort wCreatorVersion;

            public WINDOWINFO(bool? filler) : this()   // Allows automatic initialization of "cbSize" with "new WINDOWINFO(null/true/false)".
            {
                cbSize = (uint)(Marshal.SizeOf(typeof(WINDOWINFO)));
            }
        }

        #region Window position

        public static class HWND
        {
            public static readonly IntPtr
                NOTOPMOST = new IntPtr(-2),
                TOPMOST = new IntPtr(-1),
                TOP = new IntPtr(0),
                BOTTOM = new IntPtr(1),
                BROADCAST = new IntPtr(0xffff);
        }

        public static class SWP
        {
            public static readonly uint
                NOSIZE = 0x0001,
                NOMOVE = 0x0002,
                NOZORDER = 0x0004,
                NOREDRAW = 0x0008,
                NOACTIVATE = 0x0010,
                DRAWFRAME = 0x0020,
                FRAMECHANGED = 0x0020,
                SHOWWINDOW = 0x0040,
                HIDEWINDOW = 0x0080,
                NOCOPYBITS = 0x0100,
                NOOWNERZORDER = 0x0200,
                NOREPOSITION = 0x0200,
                NOSENDCHANGING = 0x0400,
                DEFERERASE = 0x2000,
                ASYNCWINDOWPOS = 0x4000;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPOS
        {
            public IntPtr hwnd;
            public IntPtr hwndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public uint flags;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr aWnd, IntPtr aWndInsertAfter, int aX, int aY, int aWidth, int aHeight, uint aFlags);

        #endregion

        #region Keyboard hook

        public static class WH
        {
            public static readonly int
                MSGFILTER = -1,
                JOURNALRECORD = 0,
                JOURNALPLAYBACK = 1,
                KEYBOARD = 2,
                GETMESSAGE = 3,
                CALLWNDPROC = 4,
                CBT = 5,
                SYSMSGFILTER = 6,
                MOUSE = 7,
                DEBUG = 9,
                SHELL = 10,
                FOREGROUNDIDLE = 11,
                CALLWNDPROCRET = 12,
                KEYBOARD_LL = 13,
                MOUSE_LL = 14;
        }

        public delegate IntPtr LowLevelKeyboardProc(int aCode, IntPtr aWParam, IntPtr aLParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int aHookType,
            LowLevelKeyboardProc aProc, IntPtr aMod, uint aThreadID);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr aHookID);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(IntPtr aHookID, int aCode,
            IntPtr aWParam, IntPtr aLParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string aModuleName);

        #endregion

        #region Enumerating top-level windows

        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder strText, int maxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool IsWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool IsIconic(IntPtr hWnd);

        #endregion

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowInfo(IntPtr hWnd, out WINDOWINFO pwi);

        public static IntPtr GetClassLongPtr(IntPtr hWnd, int nIndex)
        {
            if (IntPtr.Size > 4)
                return GetClassLongPtr64(hWnd, nIndex);
            else
                return new IntPtr(GetClassLongPtr32(hWnd, nIndex));
        }

        [DllImport("user32.dll", EntryPoint = "GetClassLong")]
        public static extern uint GetClassLongPtr32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetClassLongPtr")]
        public static extern IntPtr GetClassLongPtr64(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool DestroyIcon(IntPtr hIcon);

        [DllImport("user32.dll")]
        public static extern IntPtr LoadIcon(IntPtr hInstance, string lpIconName);

        [DllImport("user32.dll")]
        public static extern IntPtr LoadIcon(IntPtr hInstance, IntPtr lpIconName);
    }
}
