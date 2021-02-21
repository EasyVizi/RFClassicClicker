using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RFClassicClicker.Core.Model;
using RFClassicClicker.View;
using RFClassicClicker.Core.Controller;
using System.Threading;

namespace RFClassicClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SendCommandByTimer sndWindow = new SendCommandByTimer();
            sndWindow.Show();
        }

        private void sendKeyBtn_Click(object sender, RoutedEventArgs e)
        {
            //Button btn = (Button) sender;

            //char[] key = btn.Tag.ToString().ToCharArray();

            //if (key.Length == 1)
            //{
            //    //TransportController.sendKeyPress(App.core.Hwnd, key.First());
            //    TransportController.sendKeyPress(App.core.Hwnd, VKCodes.VK_KEY_F8);
            //}

            TransportController transController = new TransportController(App.core.HwndList.Values.ElementAt(0), VKCodes.VK_KEY_F1);

            Thread thread = new Thread(transController.sendKeyPress);

            thread.Start();
        }

        private void sendKeyBtn2_Click(object sender, RoutedEventArgs e)
        {
            TransportController transController = new TransportController(App.core.HwndList.Values.ElementAt(1), VKCodes.VK_KEY_F1);

            Thread thread = new Thread(transController.sendKeyPress);

            thread.Start();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            IntPtr test = HandleController.findWindowByCaption("RFO #0");

            TransportController transController = new TransportController(test, VKCodes.VK_KEY_F1);

            Thread thread = new Thread(transController.sendKeyPress);

            thread.Start();
        }
    }
}
