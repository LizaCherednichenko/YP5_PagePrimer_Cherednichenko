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

namespace YP5_PagePrimer_Cherednichenko
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window Window1 = new Window1();
            Window1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window Window2 = new Window2();
            Window2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window Window3 = new Window3();
            Window3.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window Window4 = new Window4();
            Window4.Show();
        }
    }
}
