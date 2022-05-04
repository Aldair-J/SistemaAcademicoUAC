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

namespace CapaPresentacion.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para Ingresante.xaml
    /// </summary>
    public partial class Ingresante : Window
    {
        public Ingresante()
        {
            InitializeComponent();
        }
        static CapaNegocios.Ingresante ingresante = new CapaNegocios.Ingresante();

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            ingresante.Nombres = txtnombres.Text.Trim();
            ingresante.Apellidos = txtapellidos.Text.Trim();
            ingresante.Codigo = txtcodigo.Text.Trim();
            ingresante.Correo = txtcorreo.Text.Trim();
            ingresante.Domicilio = txtdomicilio.Text.Trim();
            ingresante.LugarNac = txtlugarNac.Text.Trim();
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            ingresante.FechaNac = FechaNac.Value;
            ingresante.FechaIng = txtfechaIngr.Text.Trim();
            ingresante.MetodoIngre = txtmetodoIngr.Text.Trim();
            ingresante.Puesto = txtpuestoIngr.Text.Trim();
            MessageBox.Show("Se ingresaron los datos correctamente");
        }

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\nNombres: " + ingresante.Nombres + "Apellidos: " + ingresante.Apellidos +
            "\nCodigo: " + ingresante.Codigo + "\nCorreo: " + ingresante.Correo +
            "\nDomicilio: " + ingresante.Domicilio + "\nLugar de Nacimiento: " + ingresante.LugarNac +
            "\nFecha de Nacimiento: " + ingresante.FechaNac + "\nFecha de Ingreso :" + ingresante.FechaIng +  
            "\nMetodo de Ingreso" + ingresante.MetodoIngre + "\nPuesto de Ingreso :"+ ingresante.Puesto);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este metodo no ha sido implementado");
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este metodo no ha sido implementado");
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este metodo no ha sido implementado");
        }

        private void btnMetodo4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este metodo no ha sido implementado");
        }

    }
}
