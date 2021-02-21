using RFClassicClicker.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using RFClassicClicker.View;

namespace RFClassicClicker.Controller
{
    class CommandGroupController
    {
        public void renderControls(SendCommandByTimer window, Grid hostGrid, List<CommandGroup> commandGroups)
        {
            try
            {
                hostGrid.Children.RemoveRange(0, hostGrid.Children.Count);

                Button addNewGroupBtn = new Button();

                addNewGroupBtn.Name = "addNewGroupBtn";
                addNewGroupBtn.Margin = new Thickness(10, 20, 0, 10);
                addNewGroupBtn.Height = 22;
                addNewGroupBtn.Content = "Добавить новую группу";
                addNewGroupBtn.Click += window.AddNewGroup_Click;
                addNewGroupBtn.HorizontalAlignment = HorizontalAlignment.Left;
                addNewGroupBtn.VerticalAlignment = VerticalAlignment.Top;

                hostGrid.Children.Add(addNewGroupBtn);

                foreach (CommandGroup group in commandGroups)
                {
                    hostGrid.Children.Add(group.ComboBox);
                    hostGrid.Children.Add(group.TextBox);
                    hostGrid.Children.Add(group.CheckBox);
                }

                window.Content = hostGrid;

                window.Height = 40 + addNewGroupBtn.Height + (10 + addNewGroupBtn.Height) * commandGroups.Count;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
        }
    }
}
