using System;
using System.Runtime.InteropServices;

namespace RFClassicClicker.Core.Model
{
    abstract class WinApiImport
    {
        [DllImport("user32.dll")]
        protected static extern int SendMessage(IntPtr hWnd, uint wMsg, uint wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        protected static extern int PostMessage(IntPtr hWnd, uint wMsg, uint wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        protected static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        protected static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll")]
        protected static extern bool SetWindowTextA(IntPtr hWnd, string lpString);

        [DllImport("user32.dll")]
        protected static extern IntPtr SetActiveWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        protected static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}
