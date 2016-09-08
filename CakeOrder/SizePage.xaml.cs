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
    /// Interaction logic for SizePage.xaml
    /// </summary>
    public partial class SizePage : Page
    {

        public List<CakeSize> SelectedSizesList;

        public SizePage()
        {
            InitializeComponent();

            SelectedSizesList = new List<CakeSize>();

            SelectedSizesList.Add(
                new CakeSize
                {
                    SizeName = "Six Inch",
                    SizeNum = SizeEnum.SixInchRound,
                    ShapeNum = ShapeEnum.Round,
                }
            );

            SelectedSizesList.Add(
                new CakeSize
                {
                    SizeName = "Half Sheet",
                    SizeNum = SizeEnum.HalfSheet,
                    ShapeNum = ShapeEnum.Rectangle,
                }

            );

            SelectedSizesList.Add(
                new CakeSize
                {
                    SizeName = "Two Third Sheet",
                    SizeNum = SizeEnum.TwoThirdSheet,
                    ShapeNum = ShapeEnum.Square,
                }
            );

            SelectedSizesList.Add(
                new CakeSize
                {
                    SizeName = "Custom",
                    SizeNum = SizeEnum.CustomSize,
                    ShapeNum = ShapeEnum.Custom,
                }
            );

            RenderSelectSizes();
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

            foreach (CakeSize c in DesignLists.DefaultSizesList.Where(x => x.ShapeNum == shape))
            {
                SelectedSizesList.Add(c);
            }

            RenderSelectSizes();
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

        private void FlavorButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.FlavorView);
        }
    }
}
