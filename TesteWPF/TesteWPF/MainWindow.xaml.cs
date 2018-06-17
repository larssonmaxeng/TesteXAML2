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

namespace TesteWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("teste");
        }
        private void BntAcao_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("teste2");
          

        }

        private void btnAcao02_Click(object sender, RoutedEventArgs e)
        {
            List<Lista> lista = new List<Lista>();
            Lista l = new Lista();
            l.Valor = 10;
            l.Texto = "kq";
            lista.Add(l);
            lista.Add(new Lista { Texto = "nsjwqnbds", Valor = 10 });
            
            //grdDados.ItemsSource= lista;
        }
    }
    public class Lista
    {

        public int Valor { get; set; }
        public string Texto { get; set; }

    }

}
