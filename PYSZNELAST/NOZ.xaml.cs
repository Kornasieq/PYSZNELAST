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
    /// Logika interakcji dla klasy NOZ.xaml
    /// </summary>
    public partial class NOZ : Window
    {
        ZAAM zaam = new ZAAM();
        public NOZ()
        {
            InitializeComponent();
        }


        private void btnSaveZam_Click(object sender, RoutedEventArgs e)
        {
            DodajJedzonko();
            this.Close();
        }
        private void DodajJedzonko()
        {
            Jedzonko jedzonko = new Jedzonko()
            {
                Id = Convert.ToInt32(textBoxID.Text),
                Id_Restauracji= Convert.ToInt32(textBoxIdRestauracji.Text),
                Nazwa = textBoxNazwa.Text,
                Cena = Convert.ToDecimal(textBoxCena.Text)
            };

            zaam.Save(jedzonko);

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
