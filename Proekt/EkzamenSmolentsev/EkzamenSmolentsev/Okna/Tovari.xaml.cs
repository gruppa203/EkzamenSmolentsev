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
using EkzamenSmolentsev.Properties;
using EkzamenSmolentsev.Okna;

namespace EkzamenSmolentsev.Okna
{
    /// <summary>
    /// Логика взаимодействия для Tovari.xaml
    /// </summary>
    public partial class Tovari : Page
    {
        public Tovari()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Fraim.MainFraim.Navigaet(new Vxod());
        }
    }
}
