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
    /// Lógica de interacción para Administrativo.xaml
    /// </summary>
    public partial class Administrativo : Window
    {
        public Administrativo()
        {
            InitializeComponent();
        }
        static CapaNegocios.Administrativo administrativo = new CapaNegocios.Administrativo();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            administrativo.Codigo = txtcodigo.Text.Trim();
            administrativo.Nombres = txtnombres.Text.Trim();
            administrativo.Apellidos = txtapellidos.Text.Trim();
            administrativo.Correo = txtcorreo.Text.Trim();
            administrativo.Domicilio = txtdomicilio.Text.Trim();
            administrativo.NumeroCel = txtnumCel.Text.Trim();
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            administrativo.FechaNac = FechaNac.Value;
            administrativo.LugarNac = txtlugarNac.Text.Trim();
            administrativo.Especialidad = txtespecialidad.Text.Trim();
            administrativo.Turno = txtturno.Text.Trim();
            MessageBox.Show("Se ingresaron los datos correctamente");

        }

        private void Escribir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\nNombres : " + administrativo.Nombres + "Apellidos : " + administrativo.Apellidos +
            "\nCodigo : " + administrativo.Codigo + "\nCorreo : " + administrativo.Correo +
            "\nDomicilio : " + administrativo.Domicilio + "\nLugar de Nacimiento : " + administrativo.LugarNac +
            "\nFecha de Nacimiento : " + administrativo.FechaNac + "\nEspecialidad :" +administrativo.Especialidad    
            + "\nExperiencia :" +administrativo.Experiencia + "\nTurno :"+administrativo.Turno);
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