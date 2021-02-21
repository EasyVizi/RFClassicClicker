using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace RFClassicClicker.Model
{
    class CommandGroup
    {
        private int groupId = 1;
        private Thickness margin = new Thickness(10, 52, 0, 10);

        private const int PADDING_TOP_BEFORE_ELEMENT = 10;
        private const int PADDING_LEFT_BEFORE_ELEMENT = 10;

        public ComboBox ComboBox { get; set; }
        public TextBox TextBox { get; set; }
        public CheckBox CheckBox { get; set; }

        public CommandGroup(CommandGroup previousGroup = null)
        {
            if (previousGroup != null)
            {
                groupId = previousGroup.groupId + 1;

                margin = calcMarginToNewPosition(previousGroup);
            }

            ComboBox = new ComboBox();
            ComboBox.Name = "ComboBox_" + groupId.ToString();
            ComboBox.Margin = margin;
            ComboBox.Width = 80;
            ComboBox.Height = 22;
            ComboBox.HorizontalAlignment = HorizontalAlignment.Left;
            ComboBox.VerticalAlignment = VerticalAlignment.Top;

            margin.Left = margin.Left + ComboBox.Width + PADDING_LEFT_BEFORE_ELEMENT;

            TextBox = new TextBox();
            TextBox.Name = "TextBox_" + groupId.ToString();
            TextBox.Margin = margin;
            TextBox.Width = 120;
            TextBox.Height = 22;
            TextBox.HorizontalAlignment = HorizontalAlignment.Left;
            TextBox.VerticalAlignment = VerticalAlignment.Top;

            margin.Left = margin.Left + TextBox.Width + PADDING_LEFT_BEFORE_ELEMENT;
            margin.Top += 3;

            CheckBox = new CheckBox();
            CheckBox.Name = "CheckBox_" + groupId.ToString();
            CheckBox.Margin = margin;
            CheckBox.HorizontalAlignment = HorizontalAlignment.Left;
            CheckBox.VerticalAlignment = VerticalAlignment.Top;
        }

        public bool renderGroup(Window window)
        {
            try
            {
                Grid hostGrid = new Grid();

                hostGrid.Children.Add(ComboBox);
                hostGrid.Children.Add(TextBox);
                hostGrid.Children.Add(CheckBox);

                window.Content = hostGrid;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());

                return false;
            }

            return true;
        }

        private Thickness calcMarginToNewPosition(CommandGroup previousGroup)
        {
            Thickness margin = new Thickness();

            margin.Left = previousGroup.ComboBox.Margin.Left;
            margin.Top = previousGroup.ComboBox.Margin.Top + previousGroup.TextBox.Height + PADDING_TOP_BEFORE_ELEMENT;
            margin.Right = 0;
            margin.Bottom = 10;

            return margin;
        }
    }
}
