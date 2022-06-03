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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1(object sender, RoutedEventArgs e)
        {
            MainW.Content = new Zamówienie();
        }

        private void Btn2(object sender, RoutedEventArgs e)
        {
            MainW.Content = new Użytkownik();
        }

        private void Btn3(object sender, RoutedEventArgs e)
        {
            MainW.Content = new Restauracja();
        }
    }
}