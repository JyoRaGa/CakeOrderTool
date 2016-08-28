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

namespace CakeOrder
{

    public class Cake
    {
        public Cake(string name, Image img) { Name = name; Image = img; }
        public string Name { get; set; }

        public string Shape { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public string Filling { get; set; }

        public Image Image { get; set; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Image i = new Image();
            i.Source = new BitmapImage(new Uri(@"Images\balloon_1.jpg", UriKind.Relative));
            ImageList.Items.Add(new Cake("Balloon Cake", i));

            i = new Image();
            i.Source = new BitmapImage(new Uri(@"..\..\Images\Cap_and_Gown.jpg", UriKind.Relative));
            ImageList.Items.Add(new Cake("Cape and Gown Cake", i));

            i = new Image();
            i.Source = new BitmapImage(new Uri(@"..\..\Images\celebration_1.jpg", UriKind.Relative));
            ImageList.Items.Add(new Cake("Celebration Cake", i));

            i = new Image();
            i.Source = new BitmapImage(new Uri(@"..\..\Images\cream-cone.jpg", UriKind.Relative));
            ImageList.Items.Add(new Cake("Cream Cone Cake", i));

            i = new Image();
            i.Source = new BitmapImage(new Uri(@"..\..\Images\FlowerGardenCake.jpg", UriKind.Relative));
            ImageList.Items.Add(new Cake("Garden Cake", i));

            i = new Image();
            i.Source = new BitmapImage(new Uri(@"..\..\Images\Mini-Cupcake-Cake.jpg", UriKind.Relative));
            ImageList.Items.Add(new Cake("Cupcake Cake", i));

            i = new Image();
            i.Source = new BitmapImage(new Uri(@"..\..\Images\Oreo_Cookie_Sandwich_Cake.png", UriKind.Relative));
            ImageList.Items.Add(new Cake("Oreo Sandwich Cake", i));
        }

        private void ItemChecked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
