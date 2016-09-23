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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public static DesignPage DesignView;

        public static ShapePage ShapeView;

        public static SizePage SizeView;

        public static ColorPage ColorView;

        public static FlavorPage FlavorView;


        public MainWindow()
        {
            InitializeComponent();

            DesignView = new DesignPage();

            ShapeView = new ShapePage();

            SizeView = new SizePage();

            ColorView = new ColorPage();

            FlavorView = new FlavorPage();

            this.NavigationService.Navigate(DesignView);
        }


        public static void LoadImage(string imagePath)
        {
            BitmapImage cakeDesignImage = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            DesignView.SelectedCakeImage.Source = cakeDesignImage;
            ShapeView.SelectedCakeImage.Source = cakeDesignImage;
            SizeView.SelectedCakeImage.Source = cakeDesignImage;
            ColorView.SelectedCakeImage.Source = cakeDesignImage;
            FlavorView.SelectedCakeImage.Source = cakeDesignImage;
        }
        public static void SelectDesign(CakeDesign design)
        {
            CakeDesign.SelectedDesign = design;
            LoadImage(CakeDesign.DesignImages[design.DesignNum]);

            if (design.DesignNum == DesignEnum.Undefined)
            {
                foreach (CakeDesign c in DesignView.ImageList.Items)
                {
                    if (c.Selected) c.Selected = false;
                }

                DesignView.LoadImageList();
            }
        }

        public static void SelectShape(CakeShape shape)
        {
            CakeDesign.SelectedShape = shape;
            SizeView.LoadImageList();

            if (CakeDesign.SelectedDesign.DesignNum == DesignEnum.Undefined)
            {
                LoadImage(CakeShape.ShapeImages[shape.ShapeNum]);
            }

            DesignView.SelectedShape.DataContext = shape;
            ShapeView.SelectedShape.DataContext = shape;
            SizeView.SelectedShape.DataContext = shape;
            ColorView.SelectedShape.DataContext = shape;
            FlavorView.SelectedShape.DataContext = shape;

            if (shape.ShapeNum == ShapeEnum.Undefined)
            {
                foreach (CakeShape c in ShapeView.ImageList.Items)
                {
                    if (c.Selected) c.Selected = false;
                }

                ShapeView.LoadImageList();
            }
        }

        public static void SelectSize(CakeSize size)
        {
            CakeDesign.SelectedSize = size;
            ShapeView.LoadImageList();

            if (CakeDesign.SelectedDesign.DesignNum == DesignEnum.Undefined)
            {
                LoadImage(CakeSize.SizeImages[size.SizeNum]);
            }

            DesignView.SelectedSize.DataContext = size;
            ShapeView.SelectedSize.DataContext = size;
            SizeView.SelectedSize.DataContext = size;
            ColorView.SelectedSize.DataContext = size;
            FlavorView.SelectedSize.DataContext = size;

            if (size.SizeNum == SizeEnum.Undefined)
            {
                foreach (CakeSize c in SizeView.ImageList.Items)
                {
                    if (c.Selected) c.Selected = false;
                }

                SizeView.LoadImageList();
            }
        }

        public static void SelectColor(CakeColor color)
        {
            CakeDesign.SelectedColor = color;

            if (CakeDesign.SelectedDesign.DesignNum == DesignEnum.Undefined)
            {
                LoadImage(CakeColor.ColorImages[color.ColorNum]);
            }

            DesignView.SelectedColor.DataContext = color;
            ShapeView.SelectedColor.DataContext = color;
            SizeView.SelectedColor.DataContext = color;
            ColorView.SelectedColor.DataContext = color;
            FlavorView.SelectedColor.DataContext = color;

            if (color.ColorNum == ColorEnum.Undefined)
            {
                foreach (CakeColor c in ColorView.ImageList.Items)
                {
                    if (c.Selected) c.Selected = false;
                }

                ColorView.LoadImageList();
            }
        }

        public static void SelectFlavor(CakeFlavor flavor)
        {
            CakeDesign.SelectedFlavor = flavor;

            if (CakeDesign.SelectedDesign.DesignNum == DesignEnum.Undefined)
            {
                LoadImage(CakeFlavor.FlavorImages[flavor.FlavorNum]);
            }

            DesignView.SelectedFlavor.DataContext = flavor;
            ShapeView.SelectedFlavor.DataContext = flavor;
            SizeView.SelectedFlavor.DataContext = flavor;
            ColorView.SelectedFlavor.DataContext = flavor;
            FlavorView.SelectedFlavor.DataContext = flavor;

            if (flavor.FlavorNum == FlavorEnum.Undefined)
            {
                foreach (CakeFlavor c in FlavorView.ImageList.Items)
                {
                    if (c.Selected) c.Selected = false;
                }

                FlavorView.LoadImageList();
            }
        }

        public void ClearSelection(Button b)
        {
            if (b.Name.Equals("ClearDesign"))
            {
                CakeDesign.SelectedDesign = new CakeDesign
                {
                    DesignName = "Not Selected",
                    DesignNum = DesignEnum.Undefined,
                    DefaultColor = ColorEnum.Blue,
                    DefaultShape = ShapeEnum.Rectangle,
                    DefaultSize = SizeEnum.HalfSheet,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.Undefined,
                    Shape = ShapeEnum.Undefined,
                    Size = SizeEnum.Undefined,
                    Flavor = FlavorEnum.Undefined,
                };

                SelectDesign(CakeDesign.SelectedDesign);
                NavigationService.Navigate(DesignView); 
            }

            else if (b.Name.Equals("ClearShape") || (b.Name.Equals("ClearSize")))
            {
                CakeDesign.SelectedShape = new CakeShape
                {
                    ShapeName = "Not selected",
                    ShapeNum = ShapeEnum.Undefined,
                };

                SelectShape(CakeDesign.SelectedShape);

                CakeDesign.SelectedSize = new CakeSize
                {
                    SizeName = "Not selected",
                    SizeNum = SizeEnum.Undefined,
                    ShapeNum = ShapeEnum.Undefined,
                };

                SelectSize(CakeDesign.SelectedSize);

                if (b.Name.Equals("ClearShape"))
                {
                    NavigationService.Navigate(ShapeView);
                }
                else
                {
                    NavigationService.Navigate(SizeView);
                }

            }

            else if (b.Name.Equals("ClearColor"))
            {
                CakeDesign.SelectedColor = new CakeColor
                {
                    ColorName = "Not selected",
                    ColorNum = ColorEnum.Undefined,
                };

                SelectColor(CakeDesign.SelectedColor);
                NavigationService.Navigate(ColorView);
            }

            else if (b.Name.Equals("ClearFlavor"))
            {
                CakeDesign.SelectedFlavor = new CakeFlavor
                {
                    FlavorName = "Not selected",
                    FlavorNum = FlavorEnum.Undefined,
                };

                SelectFlavor(CakeDesign.SelectedFlavor);
                NavigationService.Navigate(FlavorView);
            }
        }
    }
}