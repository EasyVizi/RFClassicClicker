using System;
using RFClassicClicker.Core.Model;

namespace RFClassicClicker.Core.Controller
{
    class TransportController : WinApiImport
    {
        public static void sendKeyPress(IntPtr hwnd, uint key)
        {
            PostMessage(hwnd, VMCodes.WM_KEYDOWN, key, IntPtr.Zero);
        }
    }
}
