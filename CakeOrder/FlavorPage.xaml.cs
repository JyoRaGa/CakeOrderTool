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
    /// Interaction logic for FlavorPage.xaml
    /// </summary>
    public partial class FlavorPage : Page
    {
        public FlavorPage()
        {
            InitializeComponent();
            foreach (CakeFlavor c in DesignLists.DefaultFlavorsList)
            {
                c.FlavorImage = new Image();
                c.FlavorImage.Source = new BitmapImage(new Uri(CakeFlavor.FlavorImages[c.FlavorNum], UriKind.Relative));
                ImageList.Items.Add(c);
            }

            Binding shapeBinding = new Binding();
            shapeBinding.Path = new PropertyPath("ShapeName");
            shapeBinding.Mode = BindingMode.OneTime;
            SelectedShape.DataContext = CakeDesign.SelectedShape;
            SelectedShape.SetBinding(TextBlock.TextProperty, shapeBinding);

            Binding sizeBinding = new Binding();
            sizeBinding.Path = new PropertyPath("SizeName");
            sizeBinding.Mode = BindingMode.OneTime;
            SelectedSize.DataContext = CakeDesign.SelectedSize;
            SelectedSize.SetBinding(TextBlock.TextProperty, sizeBinding);

            Binding colorBinding = new Binding();
            colorBinding.Path = new PropertyPath("ColorName");
            colorBinding.Mode = BindingMode.OneTime;
            SelectedColor.DataContext = CakeDesign.SelectedColor;
            SelectedColor.SetBinding(TextBlock.TextProperty, colorBinding);

            Binding flavorBinding = new Binding();
            flavorBinding.Path = new PropertyPath("FlavorName");
            flavorBinding.Mode = BindingMode.OneTime;
            SelectedFlavor.DataContext = CakeDesign.SelectedFlavor;
            SelectedFlavor.SetBinding(TextBlock.TextProperty, flavorBinding);
        }

        private void ItemChecked(object sender, RoutedEventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            CakeFlavor cs = (CakeFlavor)c.DataContext;

            MainWindow.SelectFlavor(cs);
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

        private void FlavorButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.FlavorView);
        }
        private void SelectionButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
