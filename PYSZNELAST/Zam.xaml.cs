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

namespace PYSZNELAST
{
    /// <summary>
    /// Logika interakcji dla klasy Zamówienie.xaml
    /// </summary>
    public partial class Zam : Page
    {
        RestauracjaEntities db = new RestauracjaEntities();
        public Zam()
        {
            InitializeComponent();
            menu.ItemsSource = db.Jedzonko.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NOZ(object sender, RoutedEventArgs e)
        {
            NOZ objNOZ = new NOZ();
            objNOZ.Show();
        }
    }
}
