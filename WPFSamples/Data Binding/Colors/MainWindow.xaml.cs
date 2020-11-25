using Colors.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Colors
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


        private void OnNewColorClicked(object sender, RoutedEventArgs args)
        {
            var button = (Button)sender;
            var colorList = (ColorItemList)button.DataContext;
            var cv = (CollectionView)CollectionViewSource.GetDefaultView(colorList);

            // add a new color based on the current one, then select the new one
            var newItem = new ColorItem((ColorItem)cv.CurrentItem);
            colorList.Add(newItem);
            cv.MoveCurrentTo(newItem);
        }

        // Event handler for the SortBy radio buttons
        private void OnSortByChanged(object sender, RoutedEventArgs args)
        {
            var rb = (RadioButton)sender;
            var sortBy = rb.Content.ToString();

            if (sortBy != null)
            {
                // sort by the user's chosen property
                var cv = (CollectionView)CollectionViewSource.GetDefaultView((IEnumerable)rb.DataContext);
                cv.SortDescriptions.Clear();
                cv.SortDescriptions.Add(new SortDescription(sortBy, ListSortDirection.Descending));
            }
        }
    }
}
