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

namespace PYSZNELAST
{
    /// <summary>
    /// Logika interakcji dla klasy NOR.xaml
    /// </summary>
    public partial class NOR : Window
    {
        REE ree = new REE();
        public NOR()
        {
            InitializeComponent();
        }

        private void BtnSaveRes_Click(object sender, RoutedEventArgs e)
        {
            DodajRestauracja();
            this.Close();
        }
        private void DodajRestauracja()
        {
            Restauracja restauracja = new Restauracja()
            {
                Id = Convert.ToInt32(textBoxIdRes.Text),
                Nazwa = textBoxNazwaRes.Text,
                Adres = textBoxAdresRes.Text
            };

            ree.Save(restauracja);

        }
    }
}
