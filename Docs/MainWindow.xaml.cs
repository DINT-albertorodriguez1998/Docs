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

namespace Docs
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _anchura;
        private string _altura;


        public string Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }


        public string Anchura
        {
            get { return _anchura; }
            set { _anchura = value; }
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {
            VentanaConfig ventanaConfig = new VentanaConfig();
            ventanaConfig.Owner = this;
            ventanaConfig.ShowDialog();
        }

        private void NuevoDocumentoButton_Click(object sender, RoutedEventArgs e)
        {
            VentanaNuevoDocumento ventanaNuevoDocumento = new VentanaNuevoDocumento();
            ventanaNuevoDocumento.Owner = this;
            ventanaNuevoDocumento.Title = "Documento " + OwnedWindows.Count.ToString();

            if(Anchura != null && Altura != null)
            {
                ventanaNuevoDocumento.Width = double.Parse(Anchura);
                ventanaNuevoDocumento.Height = double.Parse(Altura);
            }
            
            ventanaNuevoDocumento.Show();
        }


    }
}
