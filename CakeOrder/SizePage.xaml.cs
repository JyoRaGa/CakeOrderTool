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
using CakeOrder.DataClasses;

namespace CakeOrder
{
    /// <summary>
    /// Interaction logic for SizePage.xaml
    /// </summary>
    public partial class SizePage : Page
    {

        public List<CakeSize> SelectedSizesList;

        public SizePage()
        {
            InitializeComponent();

            SelectedSizesList = new List<CakeSize>();

            SelectShape(ShapeEnum.Undefined);

            Binding shapeBinding = new Binding();
            shapeBinding.Path = new PropertyPath("ShapeName");
            shapeBinding.Mode = BindingMode.OneTime;
            SelectedShape.DataContext = CakeDesign.SelectedShape;
            SelectedShape.SetBinding(TextBlock.TextProperty, shapeBinding);

            Binding sizeBinding = new Binding();
            sizeBinding.Path = new PropertyPath("SizeName");
            sizeBinding.Mode = BindingMode.OneTime;
            sizeBinding.Source = CakeDesign.SelectedSize;
            SelectedSize.DataContext = CakeDesign.SelectedSize;
            SelectedSize.SetBinding(TextBlock.TextProperty, sizeBinding);

            Binding colorBinding = new Binding();
            colorBinding.Path = new PropertyPath("ColorName");
            colorBinding.Mode = BindingMode.OneTime;
            colorBinding.Source = CakeDesign.SelectedColor;
            SelectedColor.DataContext = CakeDesign.SelectedColor;
            SelectedColor.SetBinding(TextBlock.TextProperty, colorBinding);

            Binding flavorBinding = new Binding();
            flavorBinding.Path = new PropertyPath("FlavorName");
            flavorBinding.Mode = BindingMode.OneTime;
            flavorBinding.Source = CakeDesign.SelectedFlavor;
            SelectedFlavor.DataContext = CakeDesign.SelectedFlavor;
            SelectedFlavor.SetBinding(TextBlock.TextProperty, flavorBinding);
        }

        public void RenderSelectSizes()
        {
            ImageList.Items.Clear();

            foreach (CakeSize c in SelectedSizesList)
            {
                c.SizeImage = new Image();
                c.SizeImage.Source = new BitmapImage(new Uri(CakeSize.SizeImages[c.SizeNum], UriKind.Relative));
                ImageList.Items.Add(c);
            }
        }

        public void SelectShape(ShapeEnum shape)
        {
            SelectedSizesList.Clear();

            if (shape == ShapeEnum.Undefined)
            {
                foreach (CakeSize c in DesignLists.DefaultSizesList)
                {
                    SelectedSizesList.Add(c);
                }
            }
            else
            {
                foreach (CakeSize c in DesignLists.DefaultSizesList.Where(x => x.ShapeNum == shape))
                {
                    SelectedSizesList.Add(c);
                }
            }

            RenderSelectSizes();
        }

        private void ItemChecked(object sender, RoutedEventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            CakeSize cs = (CakeSize)c.DataContext;

            CakeDesign.SelectedSize = cs;
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
