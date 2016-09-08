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
using CakeOrder.DataClasses;

namespace CakeOrder
{
    /// <summary>
    /// Interaction logic for ShapePage.xaml
    /// </summary>
    public partial class ShapePage : Page
    {
        public ShapePage()
        {
            InitializeComponent();
            foreach (CakeShape c in DesignLists.DefaultShapeList)
            {
                c.ShapeImage = new Image();
                c.ShapeImage.Source = new BitmapImage(new Uri(CakeShape.ShapeImages[c.ShapeNum], UriKind.Relative));
                ImageList.Items.Add(c);
            }

        }

        private void ItemChecked(object sender, RoutedEventArgs e)
        {

        }
        private void DesignButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.DesignView);
        }

        private void ShapeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.ShapeView);
        }

        private void SizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.SizeView);
        }

        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.ColorView);
        }

        private void FillingButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.FillingView);
        }
    }
}
