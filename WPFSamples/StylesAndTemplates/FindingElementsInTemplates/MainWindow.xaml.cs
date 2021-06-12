﻿using System;
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

namespace FindingElementsInTemplates
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


        private void ControlTemplateFindElement(object sender, RoutedEventArgs e)
        {
            // Finding the grid that is generated by the ControlTemplate of the Button
            var gridInTemplate = (Grid)myButton1.Template.FindName("grid", myButton1);

            // Do something to the ControlTemplate-generated grid
            MessageBox.Show("The actual width of the grid in the ControlTemplate: "
                            + gridInTemplate.GetValue(ActualWidthProperty));
        }

        private void DataTemplateFindElement(object sender, RoutedEventArgs e)
        {
            // Getting the currently selected ListBoxItem
            // Note that the ListBox must have
            // IsSynchronizedWithCurrentItem set to True for this to work
            var myListBoxItem =
                (ListBoxItem)(myListBox.ItemContainerGenerator.ContainerFromItem(myListBox.Items.CurrentItem));

            // Getting the ContentPresenter of myListBoxItem
            var myContentPresenter = FindVisualChild<ContentPresenter>(myListBoxItem);

            // Finding textBlock from the DataTemplate that is set on that ContentPresenter
            var myDataTemplate = myContentPresenter.ContentTemplate;
            var myTextBlock = (TextBlock)myDataTemplate.FindName("textBlock", myContentPresenter);

            // Do something to the DataTemplate-generated TextBlock
            MessageBox.Show("The text of the TextBlock of the selected list item: "
                            + myTextBlock.Text);
        }

        private TChildItem FindVisualChild<TChildItem>(DependencyObject obj)
            where TChildItem : DependencyObject
        {
            for (var i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                var child = VisualTreeHelper.GetChild(obj, i);
                if (child is TChildItem)
                    return (TChildItem)child;
                var childOfChild = FindVisualChild<TChildItem>(child);
                if (childOfChild != null)
                    return childOfChild;
            }
            return null;
        }
    }
}
