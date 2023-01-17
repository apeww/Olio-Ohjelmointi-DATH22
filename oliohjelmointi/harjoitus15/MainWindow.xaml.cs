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

namespace harjoitus15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Rekka = 0;
        int Auto = 0;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rekka++;
            txt_Ajoneuvo1.Text = "Rekkoja on " + Rekka; 
        }

        private void btn_LisääRekka_Click(object sender, RoutedEventArgs e)
        {
            Auto++;
            Ajoneuvo2.Text = "Autoja on " + Auto;
        }
    }
}
