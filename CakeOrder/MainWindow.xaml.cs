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
    }
}
