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

        ZAAM zaam = new ZAAM();
        public Zam()
        {
            InitializeComponent();
            menu.ItemsSource = db.Jedzonko.ToList();
           
        }

        private void NOZ(object sender, RoutedEventArgs e)
        {
            NOZ objNOZ = new NOZ();
            objNOZ.Show();
        }

        private void SaveNOZ(object sender, RoutedEventArgs e)
        {
            Jedzonko jedzonko = new Jedzonko();
            db.SaveChanges();
        }

        private void btnDeleteZam_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = menu.SelectedItem as Jedzonko;
            if (selectedItem != null)
            {
                zaam.Remove(selectedItem.Id);
                menu.ItemsSource = db.Jedzonko.ToList();
                menu.Items.Refresh();
            }
        }
    }
}
