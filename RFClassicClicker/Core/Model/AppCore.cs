using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using RFClassicClicker.Core.Controller;

namespace RFClassicClicker.Core.Model
{
    public class AppCore
    {
        public IntPtr Hwnd { get; set; }
        internal VKCodes VkCodes { get; set; }

        public AppCore()
        {
            VkCodes = new VKCodes();
            Hwnd = HandleController.findWindowByCaption("RF Classic");
        }
    }
}
