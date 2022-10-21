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
    /// Логика взаимодействия для Page13.xaml
    /// </summary>
    public partial class Page13 : Page
    {
        public Page13()
        {
            InitializeComponent();

            List<Stroka> strokas = new List<Stroka>();
            strokas.Add(new Stroka() { Id = 1, JID = "1", JD = new DateTime(2015, 4, 28), UID = "Admin", IS = "Initial Logged Job", Screen = "Initial Logged Job", FI = "Initial Logged Job", JS = "Closed" });
            strokas.Add(new Stroka() { Id = 2, JID = "2", JD = new DateTime(2015, 4, 28), UID = "geoffc", IS = "Test 2", Screen = "Test 2", FI = "Test 2", JS = "Open" });

            dg1.ItemsSource = strokas;

        }

        public class Stroka
        {
            public int Id { get; set; }

            public string JID { get; set; }
            public DateTime JD { get; set; }
            public string UID { get; set; }
            public string IS { get; set; }
            public string Screen { get; set; }
            public string FI { get; set; }
            public string JS { get; set; }

        }

    }
}
