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
using ValidateItemsInItemsControl.Data;

namespace ValidateItemsInItemsControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Customers _customerData;
        private BindingGroup _bindingGroupInError;

        public MainWindow()
        {
            InitializeComponent();
            _customerData = new Customers();
            customerList.DataContext = _customerData;
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (_bindingGroupInError == null)
            {
                _customerData.Add(new Customer());
            }
            else
            {
                MessageBox.Show("Please correct the data in error before adding a new customer.");
            }
        }

        private void saveCustomer_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var container = (FrameworkElement)customerList.ContainerFromElement(btn);

            // If the user is trying to change an items, when another item has an error,
            // display a message and cancel the currently edited item.
            if (_bindingGroupInError != null && _bindingGroupInError != container?.BindingGroup)
            {
                MessageBox.Show("Please correct the data in error before changing another customer");
                container.BindingGroup.CancelEdit();
                return;
            }

            if (container.BindingGroup.ValidateWithoutUpdate())
            {
                container.BindingGroup.UpdateSources();
                _bindingGroupInError = null;
                MessageBox.Show("Item Saved");
            }
            else
            {
                _bindingGroupInError = container.BindingGroup;
            }
        }

    }
}
