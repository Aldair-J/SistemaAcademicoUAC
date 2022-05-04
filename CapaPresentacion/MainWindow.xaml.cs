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

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Docente docente = new Mantenimiento.Docente();
            docente.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Administrativo administrativo= new Mantenimiento.Administrativo();
            administrativo.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Regular regular = new Mantenimiento.Regular();
            regular.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Ingresante ingresante = new Mantenimiento.Ingresante();
            ingresante.Show();
        }
    }
}
