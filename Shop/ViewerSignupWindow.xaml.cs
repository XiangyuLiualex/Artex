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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Artex
{
    /// <summary>
    /// Interaction logic for BuyerSignupWindow.xaml
    /// </summary>
    public partial class ViewerSignupWindow : Page
    {
        public ViewerSignupWindow()
        {
            InitializeComponent();
        }
        private void txt_userName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void txt_password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void txt_confirmPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (this.txt_userName.Text.ToString() == "123")
            {
                MessageBox.Show("Failed! Username already exist!!!");
            }
            else if(this.txt_password.Text.ToString()!= this.txt_confirmPassword.Text.ToString())
            {
                MessageBox.Show("Failed! Password is not same with the comfirm Password!!!");
            }
            else
            {
                MessageBox.Show("Signup successfully!!!");
                NavigationService.GetNavigationService(this).Navigate(new System.Uri("Page1.xaml", UriKind.Relative));
            }
        }
    }
}
