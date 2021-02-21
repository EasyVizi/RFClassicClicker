using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using RFClassicClicker.Core.Controller;

namespace RFClassicClicker.Core.Model
{
    public class AppCore
    {
        public Dictionary<string, IntPtr> HwndList { get; set; }
        internal VKCodes VkCodes { get; set; }

        public AppCore()
        {
            VkCodes = new VKCodes();
            HwndList = new Dictionary<string, IntPtr>();
            IntPtr hWnd = IntPtr.Zero;

            do
            {
                hWnd = HandleController.findWindowByCaption("RF Classic");

                string newWindowName = "RFO #" + (HwndList.Count + 1).ToString();
                HandleController.setWindowTitle(hWnd, "RFO #" + HwndList.Count.ToString());

                HwndList.Add(newWindowName, hWnd);
            } while (hWnd.ToInt32() != 0);
        }
    }
}
