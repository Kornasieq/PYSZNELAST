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
    /// Logika interakcji dla klasy Użytkownik.xaml
    /// </summary>
    public partial class Użytkownik : Page
    {
        RestauracjaEntities db = new RestauracjaEntities();

        UZO uzo = new UZO();    
        public Użytkownik()
        {
            InitializeComponent();
            Uzytk.ItemsSource = db.Użytkownicy.ToList();
        }

        private void NOU(object sender, RoutedEventArgs e)
        {
            NOU objNOU = new NOU();
            objNOU.Show();
        }

        private void Uzytk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SaveNOU(object sender, RoutedEventArgs e)
        {
            Użytkownicy użytkownicy = new Użytkownicy();
            db.SaveChanges();
        }

        private void btnDeleteUżytkownik_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = Uzytk.SelectedItem as Użytkownicy;
            if (selectedItem != null)
            {
                uzo.Remove(selectedItem.Id);
                Uzytk.ItemsSource = db.Użytkownicy.ToList();
                Uzytk.Items.Refresh();
            }

        }
    }
}
