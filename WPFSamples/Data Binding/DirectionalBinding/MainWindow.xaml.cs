﻿using DirectionalBinding.Data;
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

namespace DirectionalBinding
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


        private void OnRentRaise(object sender, RoutedEventArgs args)
        {
            // Update bills
            var random = new Random();
            double i = random.Next(10);
            var bindingExpression =
                BindingOperations.GetBindingExpression(SavingsText, TextBlock.TextProperty);
            var sourceData = (NetIncome)bindingExpression.DataItem;
            sourceData.Rent = (int)((1 + i / 100) * sourceData.Rent);
        }

        private void OnTargetUpdated(object sender, DataTransferEventArgs args)
        {
            // Handle event
            var fe = sender as FrameworkElement;
            infoText.Text = "";
            infoText.Text += args.Property.Name + " property of a " + args.Property.OwnerType.Name;
            infoText.Text += " element (";
            infoText.Text += fe.Name;
            infoText.Text += ") updated...";
            infoText.Text += DateTime.Now.ToLongDateString();
            infoText.Text += " at ";
            infoText.Text += DateTime.Now.ToLongTimeString();
        }
    }
}
