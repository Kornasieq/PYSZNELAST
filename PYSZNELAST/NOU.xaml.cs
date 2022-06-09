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
    /// Logika interakcji dla klasy NOU.xaml
    /// </summary>
    public partial class NOU : Window
    {
        UZO uzo = new UZO(); 
        public NOU()
        {
            InitializeComponent();
        }

        private void BtnSaveNou_Click(object sender, RoutedEventArgs e)
        {
            if (DodajUżytkownicy() == true)
            {
                this.Close();
            }
        }

        private bool DodajUżytkownicy()
        {
            if(Validation() == true)
            {
                Użytkownicy użytkownicy = new Użytkownicy()
                 {
                Id = Convert.ToInt32(textBoxIdUzo.Text),
                Nazwa_Użytkownika = textBoxNazwaUzo.Text,
                Hasło = textBoxHasloUzo.Text,
                Adres = textBoxAdresUzo.Text
                };
           
                    uzo.Save(użytkownicy);
                return true;
            
            
            }
            return false;
        }

        private bool Validation()
        {
           if(textBoxHasloUzo.Text.Length < 8)
            {
                if (MessageBox.Show("Hasło musi miec powyżej 8 znaków", "Hasło", MessageBoxButton.OK, MessageBoxImage.Warning) == MessageBoxResult.OK)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
