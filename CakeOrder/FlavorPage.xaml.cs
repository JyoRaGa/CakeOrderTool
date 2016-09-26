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

            LoadImageList();

            Binding designBinding = new Binding();
            designBinding.Path = new PropertyPath("DesignName");
            designBinding.Mode = BindingMode.OneTime;
            DesignButton.DataContext = CakeDesign.SelectedDesign;
            DesignButton.SetBinding(Button.ContentProperty, designBinding);

            Binding shapeBinding = new Binding();
            shapeBinding.Path = new PropertyPath("ShapeName");
            shapeBinding.Mode = BindingMode.OneTime;
            ShapeButton.DataContext = CakeDesign.SelectedShape;
            ShapeButton.SetBinding(Button.ContentProperty, shapeBinding);

            Binding sizeBinding = new Binding();
            sizeBinding.Path = new PropertyPath("SizeName");
            sizeBinding.Mode = BindingMode.OneTime;
            SizeButton.DataContext = CakeDesign.SelectedSize;
            SizeButton.SetBinding(Button.ContentProperty, sizeBinding);

            Binding colorBinding = new Binding();
            colorBinding.Path = new PropertyPath("ColorName");
            colorBinding.Mode = BindingMode.OneTime;
            ColorButton.DataContext = CakeDesign.SelectedColor;
            ColorButton.SetBinding(Button.ContentProperty, colorBinding);

            Binding flavorBinding = new Binding();
            flavorBinding.Path = new PropertyPath("FlavorName");
            flavorBinding.Mode = BindingMode.OneTime;
            FlavorButton.DataContext = CakeDesign.SelectedFlavor;
            FlavorButton.SetBinding(Button.ContentProperty, flavorBinding);
        }

        public void LoadImageList()
        {
            ImageList.Items.Clear();

            foreach (CakeFlavor c in DesignLists.DefaultFlavorsList)
            {
                if (c.FlavorNum == FlavorEnum.Undefined) continue;
                c.FlavorImage = new Image();
                c.FlavorImage.Source = new BitmapImage(new Uri(CakeFlavor.FlavorImages[c.FlavorNum], UriKind.Relative));
                ImageList.Items.Add(c);
            }
        }

        private void ItemChecked(object sender, RoutedEventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            CakeFlavor cs = (CakeFlavor)c.DataContext;

            MainWindow.SelectFlavor(cs);
        }

        private void ItemClicked(object sender, RoutedEventArgs e)
        {
            Button c = (Button)sender;
            CakeFlavor cs = (CakeFlavor)c.DataContext;

            MainWindow.SelectFlavor(cs);
            ((RadioButton)((StackPanel)c.Parent).Children[0]).IsChecked = true;
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
            ((MainWindow)Parent).ClearSelection((Button)sender);
        }
    }
}
