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
    /// Interaction logic for DesignPage.xaml
    /// </summary>
    public partial class DesignPage : Page
    {
        public DesignPage()
        {
            InitializeComponent();

            foreach (CakeDesign c in DesignLists.DefaultDesignList)
            {
                c.CakeImage.Source = new BitmapImage(new Uri(c.ImagePath, UriKind.Relative));
                ImageList.Items.Add(c);
            }
        }

        private void ItemChecked(object sender, RoutedEventArgs e)
        {

        }

        private void ShapeButton_Click(object sender, RoutedEventArgs e)
        {
            ShapePage shapePage = new ShapePage();
            this.NavigationService.Navigate(shapePage);
        }
    }
}
