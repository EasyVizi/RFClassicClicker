using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using RFClassicClicker.Core.Model;

namespace RFClassicClicker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static AppCore core;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            core = new AppCore();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
