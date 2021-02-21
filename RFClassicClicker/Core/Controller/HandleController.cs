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
    }
}
