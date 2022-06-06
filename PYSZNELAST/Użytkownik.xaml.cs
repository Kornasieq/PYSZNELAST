﻿using System;
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
    }
}
