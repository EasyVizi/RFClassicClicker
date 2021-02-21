using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RFClassicClicker.Model;
using RFClassicClicker.Controller;

namespace RFClassicClicker.View
{
    public partial class SendCommandByTimer : Window
    {
        private CommandGroupController CmdGroupsController { get; set; }
        internal List<CommandGroup> CommandGroups { get; set; }
        private Grid HostGrid { get; set; }

        public SendCommandByTimer()
        {
            InitializeComponent();

            CmdGroupsController = new CommandGroupController();
            CommandGroups = new List<CommandGroup>();
            HostGrid = new Grid();

            CommandGroup commandGroup = new CommandGroup();
            CommandGroups.Add(commandGroup);

            CmdGroupsController.renderControls(this, HostGrid, CommandGroups);
        }

        public void AddNewGroup_Click(object sender, RoutedEventArgs e)
        {
            CommandGroup cmdGroup = new CommandGroup(CommandGroups[CommandGroups.Count - 1]);
            CommandGroups.Add(cmdGroup);

            CmdGroupsController.renderControls(this, HostGrid, CommandGroups);
        }
    }
}
