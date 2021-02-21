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
            Button btn = (Button) sender;

            char[] key = btn.Tag.ToString().ToCharArray();

            if (key.Length == 1)
            {
                TransportController.sendKeyPress(App.core.Hwnd, key.First());
            }
        }
    }
}
