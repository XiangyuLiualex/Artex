﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Shop
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class MainHeader : Window
    {
        public MainHeader()
        {
            InitializeComponent();
        }


        void PopUp(object sender, RoutedEventArgs e)
        {
            if (ProfileOptions.Visibility == Visibility.Visible)
                ProfileOptions.Visibility = Visibility.Hidden;
            else if (ProfileOptions.Visibility == Visibility.Hidden)
                ProfileOptions.Visibility = Visibility.Visible;
        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {
           
             
            WindowContent.Navigate(new System.Uri("Sales.xaml",
             UriKind.RelativeOrAbsolute));
            Heading.Text = "Sales";
            //BrushConverter bc = new BrushConverter();
            // Sales.Background =  (Brush)bc.ConvertFrom("#ffc0c0");
        }
        private void EditShop_Click(object sender, RoutedEventArgs e)
        {
            WindowContent.Navigate(new System.Uri("EditShopPage.xaml",
              UriKind.RelativeOrAbsolute));
            Heading.Text = "Edit Shop";
            Thickness margin = Profile.Margin;
            margin.Left = 350;
            Profile.Margin = margin;
            
           // BrushConverter bc = new BrushConverter();
           // EditShop.Background = (Brush)bc.ConvertFrom("#ffc0c0");
        }
    }
}
