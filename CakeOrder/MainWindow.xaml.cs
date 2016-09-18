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
        }

        public static void SelectShape(CakeShape shape)
        {
            CakeDesign.SelectedShape = shape;
            SizeView.SelectShape(shape.ShapeNum);

            if (CakeDesign.SelectedDesign.DesignNum == DesignEnum.Undefined)
            {
                LoadImage(CakeShape.ShapeImages[shape.ShapeNum]);
            }

            DesignView.SelectedShape.DataContext = shape;
            ShapeView.SelectedShape.DataContext = shape;
            SizeView.SelectedShape.DataContext = shape;
            ColorView.SelectedShape.DataContext = shape;
            FlavorView.SelectedShape.DataContext = shape;
        }

        public static void SelectSize(CakeSize size)
        {
            CakeDesign.SelectedSize = size;
            ShapeView.SelectSize(size.SizeNum);

            if (CakeDesign.SelectedDesign.DesignNum == DesignEnum.Undefined)
            {
                LoadImage(CakeSize.SizeImages[size.SizeNum]);
            }

            DesignView.SelectedSize.DataContext = size;
            ShapeView.SelectedSize.DataContext = size;
            SizeView.SelectedSize.DataContext = size;
            ColorView.SelectedSize.DataContext = size;
            FlavorView.SelectedSize.DataContext = size;
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
        }
    }
}
