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

namespace DragonBallMatching.Views
{
    /// <summary>
    /// Interaction logic for NewAccount_01.xaml
    /// </summary>
    public partial class NewAccount_01 : Page
    {
        public NewAccount_01()
        {
            InitializeComponent();

        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            NewAccount_02 newAccount_02 = new NewAccount_02();
            NavigationService.Navigate(newAccount_02);
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}