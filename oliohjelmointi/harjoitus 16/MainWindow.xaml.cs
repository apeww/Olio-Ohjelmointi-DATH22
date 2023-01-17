using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace harjoitus_16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Luku;
        

        public MainWindow()
        {

            InitializeComponent();


        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_MuunnaKilometreiksi_Click(object sender, RoutedEventArgs e)
        {
            Luku = int.Parse(input_Luku.Text);
            float conversionRate = 1.62137f;
            txt_LoppuTulos.Text = "Kilometreinä on: " + Luku * conversionRate;
        }

        private void btn_MuunnaMaileksi_Click(object sender, RoutedEventArgs e)
        {
            Luku = int.Parse(input_Luku.Text);
            float conversionRate = 0.62137f;
            txt_LoppuTulos.Text = "Maileina on: " + Luku * conversionRate;
        }

        private void input_Luku_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
