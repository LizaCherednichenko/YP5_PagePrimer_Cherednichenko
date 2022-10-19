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
using System.Windows.Shapes;

namespace YP5_PagePrimer_Cherednichenko
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void step1_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new Uri("Page6.xaml", UriKind.Relative));
        }

        private void step2_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new Uri("Page7.xaml", UriKind.Relative));
        }

        private void step3_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new Uri("Page8.xaml", UriKind.Relative));
        }

        private void step4_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new Uri("Page9.xaml", UriKind.Relative));
        }

        private void step5_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new Uri("Page10.xaml", UriKind.Relative));
        }
    }
}
