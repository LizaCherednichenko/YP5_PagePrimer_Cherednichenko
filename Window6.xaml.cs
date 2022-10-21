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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            f1.Navigate(new Uri("Page15.xaml", UriKind.Relative));
        }

        private void Image_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            f1.Navigate(new Uri("Page16.xaml", UriKind.Relative));
        }

        private void Image_MouseUp_2(object sender, MouseButtonEventArgs e)
        {
            f1.Navigate(new Uri("Page17.xaml", UriKind.Relative));
        }

        private void Image_MouseUp_3(object sender, MouseButtonEventArgs e)
        {
            f1.Navigate(new Uri("Page18.xaml", UriKind.Relative));
        }

        private void Image_MouseUp_4(object sender, MouseButtonEventArgs e)
        {
            f1.Navigate(new Uri("Page19.xaml", UriKind.Relative));
        }
    }
}
