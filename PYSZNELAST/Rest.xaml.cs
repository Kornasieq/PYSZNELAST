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
    /// Logika interakcji dla klasy Restauracja.xaml
    /// </summary>
    public partial class Rest : Page
    {
        REE ree = new REE();

        RestauracjaEntities db = new RestauracjaEntities();
        public Rest()
        {
            InitializeComponent();
            restt.ItemsSource = db.Restauracja.ToList();
        }

        private void NOR(object sender, RoutedEventArgs e)
        {
            NOR objNOR = new NOR();
            objNOR.Show();
        }

        private void SaveEdit(object sender, RoutedEventArgs e)
        {
            Restauracja restauracja = new Restauracja();
            db.SaveChanges();
        }

        private void btnDeleteRestauracja_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = restt.SelectedItem as Restauracja;
            if (selectedItem != null)
            {
                ree.Remove(selectedItem.Id);
                restt.ItemsSource = db.Użytkownicy.ToList();
                restt.Items.Refresh();
            }
        }
    }
}
