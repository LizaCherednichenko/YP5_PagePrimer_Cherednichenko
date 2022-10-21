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

namespace YP5_PagePrimer_Cherednichenko
{
    /// <summary>
    /// Логика взаимодействия для Page12.xaml
    /// </summary>
    public partial class Page12 : Page
    {


        public Page12()
        {
            InitializeComponent();

            List<Stroka> strokas = new List<Stroka>();
            strokas.Add(new Stroka() { Id = 1, Mesto = "Вход в офис", Toch="У двери", SNom = "55404403", IP = "192.163.201.89", MAC = "00:60:38:22:02:CE", SostPod = "Подключен" , Det = new DateTime(2016, 6, 24)});

            dg1.ItemsSource = strokas;

            

        }

        public class Stroka
        {
            public int Id { get; set; }

            public string Mesto { get; set; }
            public string Toch { get; set; }
            public string SNom { get; set; }
            public string IP { get; set; }
            public string MAC { get; set; }
            public string SostPod { get; set; }
            public DateTime Det { get; set; }

        }

    }
}
