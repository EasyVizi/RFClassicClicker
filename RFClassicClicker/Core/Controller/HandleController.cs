using System;
using RFClassicClicker.Core.Model;

namespace RFClassicClicker.Core.Controller
{
    class HandleController : WinApiImport
    {
        public static IntPtr findWindowByCaption(string lpWindowName)
        {
            return FindWindowByCaption(IntPtr.Zero, lpWindowName);
        }

        public static bool setWindowTitle(IntPtr hWnd, string name)
        {
            return SetWindowTextA(hWnd, name);
        }

        public static IntPtr setActiveWindow(IntPtr hWnd)
        {
            return SetActiveWindow(hWnd);
        }

        public static bool setForegroundWindow(IntPtr hWnd)
        {
            return SetForegroundWindow(hWnd);
        }
    }
}
