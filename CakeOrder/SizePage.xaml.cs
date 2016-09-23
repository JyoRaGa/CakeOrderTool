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

        public SizePage()
        {
            InitializeComponent();

            foreach (CakeSize c in DesignLists.DefaultSizesList)
            {
                if (c.SizeNum == SizeEnum.Undefined) continue;
                c.SizeImage = new Image();
                c.SizeImage.Source = new BitmapImage(new Uri(CakeSize.SizeImages[c.SizeNum], UriKind.Relative));
                ImageList.Items.Add(c);
            }

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

            foreach (CakeSize c in DesignLists.DefaultSizesList)
            {
                if (c.SizeNum == SizeEnum.Undefined) continue;

                c.SizeImage = new Image();
                c.SizeImage.Source = new BitmapImage(new Uri(CakeSize.SizeImages[c.SizeNum], UriKind.Relative));

                if (CakeDesign.SelectedShape.ShapeNum == ShapeEnum.Undefined ||
                    (CakeDesign.SelectedShape.ShapeNum != ShapeEnum.Undefined &&
                DesignLists.DefaultSizesList.Exists(x => (x.ShapeNum == CakeDesign.SelectedShape.ShapeNum) && (x.SizeNum == c.SizeNum)))
                )
                {
                    c.Enabled = true;
                    c.SizeImage.Opacity = 1;
                }
                else
                {
                    c.Enabled = false;
                    c.SizeImage.Opacity = 0.2;
                }

                ImageList.Items.Add(c);
            }
        }

        private void ItemChecked(object sender, RoutedEventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            CakeSize cs = (CakeSize)c.DataContext;

            MainWindow.SelectSize(cs);
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
