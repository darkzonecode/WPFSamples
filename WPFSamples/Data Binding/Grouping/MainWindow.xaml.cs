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

namespace Grouping
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CollectionView _myView;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddGrouping(object sender, RoutedEventArgs e)
        {
            _myView = (CollectionView)CollectionViewSource.GetDefaultView(myItemsControl.ItemsSource);
            if (_myView.CanGroup)
            {
                var groupDescription
                    = new PropertyGroupDescription("@Type");
                _myView.GroupDescriptions.Add(groupDescription);
            }
        }

        private void RemoveGrouping(object sender, RoutedEventArgs e)
        {
            _myView = (CollectionView)CollectionViewSource.GetDefaultView(myItemsControl.ItemsSource);
            _myView.GroupDescriptions.Clear();

            
        }
    }
}
