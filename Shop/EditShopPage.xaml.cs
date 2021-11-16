using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop
{
    /// <summary>
    /// Interaction logic for EditShopPage.xaml
    /// </summary>
    public partial class EditShopPage : Page
    {
        public EditShopPage()
        {
            InitializeComponent();
        }
        void RightMove(object sender, RoutedEventArgs e)
        {
            if (Image1.Visibility == Visibility.Visible)
            {
                Image1.Visibility = Visibility.Hidden;
                Image2.Visibility = Visibility.Visible;
                Image3.Visibility = Visibility.Hidden;
            }
            else if (Image2.Visibility == Visibility.Visible)
            {
                Image1.Visibility = Visibility.Hidden;
                Image2.Visibility = Visibility.Hidden;
                Image3.Visibility = Visibility.Visible;
            }
            else if (Image3.Visibility == Visibility.Visible)
            {
                Image1.Visibility = Visibility.Visible;
                Image2.Visibility = Visibility.Hidden;
                Image3.Visibility = Visibility.Hidden;
            }
        }

        void LeftMove(object sender, RoutedEventArgs e)
        {
            if (Image1.Visibility == Visibility.Visible)
            {
                Image1.Visibility = Visibility.Hidden;
                Image3.Visibility = Visibility.Visible;
                Image2.Visibility = Visibility.Hidden;
            }
            else if (Image2.Visibility == Visibility.Visible)
            {
                Image2.Visibility = Visibility.Hidden;
                Image3.Visibility = Visibility.Hidden;
                Image1.Visibility = Visibility.Visible;
            }
            else if (Image3.Visibility == Visibility.Visible)
            {
                Image2.Visibility = Visibility.Visible;
                Image1.Visibility = Visibility.Hidden;
                Image3.Visibility = Visibility.Hidden;
            }
        }

    }
}
