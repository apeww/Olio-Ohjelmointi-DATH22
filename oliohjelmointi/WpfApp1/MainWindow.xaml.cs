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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string KäyttäjänNimi;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_EkaNappi_Click(object sender, RoutedEventArgs e)
        {
            KäyttäjänNimi = input_Nimi1.Text;
            txt_EkaTeksti.Text = "Nimesi on = " + KäyttäjänNimi;
        }
    }
}
