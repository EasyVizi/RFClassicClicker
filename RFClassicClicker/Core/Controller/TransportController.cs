using System;
using System.Threading;
using RFClassicClicker.Core.Model;

namespace RFClassicClicker.Core.Controller
{
    class TransportController : WinApiImport
    {
        public IntPtr CurrentHwnd { get; set; }
        public uint CurrentKey { get; set; }

        public TransportController(IntPtr hwnd, uint key)
        {
            CurrentKey = key;
            CurrentHwnd = hwnd;
        }

        public void sendKeyPress()
        {
            while (true)
            {
                SetForegroundWindow(CurrentHwnd);
                SetActiveWindow(CurrentHwnd);
                Thread.Sleep(50);

                PostMessage(CurrentHwnd, VMCodes.WM_KEYDOWN, CurrentKey, IntPtr.Zero);
                Thread.Sleep(1000);
            }
        }
    }
}
