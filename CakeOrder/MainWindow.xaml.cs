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

    //public class Cake
    //{
    //    public Cake(string name, Image img) { Name = name; Image = img; }
    //    public string Name { get; set; }

    //    public string Shape { get; set; }

    //    public string Color { get; set; }

    //    public string Size { get; set; }

    //    public string Filling { get; set; }

    //    public Image Image { get; set; }
    //}

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
    }
}
