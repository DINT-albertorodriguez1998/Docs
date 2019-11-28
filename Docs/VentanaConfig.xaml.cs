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

namespace Docs
{
    /// <summary>
    /// Lógica de interacción para VentanaConfig.xaml
    /// </summary>
    public partial class VentanaConfig : Window
    {
        public VentanaConfig()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            (Owner as MainWindow).Altura = AltoTextBox.Text;
            (Owner as MainWindow).Anchura = AnchoTextBox.Text;
            Close();
        }

        private void CancerlarButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
