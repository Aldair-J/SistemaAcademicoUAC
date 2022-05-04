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
    /// Lógica de interacción para Docente.xaml
    /// </summary>
    public partial class Docente : Window
    {
        public Docente()
        {
            InitializeComponent();
        }
        static CapaNegocios.Docente docente = new CapaNegocios.Docente();

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            docente.Nombres = txtnombres.Text.Trim();
            docente.Apellidos = txtapellidos.Text.Trim();
            docente.Codigo = txtcodigo.Text.Trim();
            docente.Correo = txtcorreo.Text.Trim();
            docente.Domicilio = txtdomicilio.Text.Trim();
            docente.LugarNac = txtlugarNac.Text.Trim();
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            docente.FechaNac = FechaNac.Value;
            docente.FechaNac = FechaNac.Value;
            docente.Afp = txtafp.Text.Trim();
            docente.Facultad = txtfacultad.Text.Trim();
            docente.Cursos = txtcursos.Text.Trim();
            MessageBox.Show("Se ingresaron los datos correctamente");
        }

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\nNombres : " + docente.Nombres + "Apellidos : " + docente.Apellidos +
            "\nCodigo : " + docente.Codigo + "\nCorreo : " + docente.Correo +
            "\nDomicilio: " + docente.Domicilio + "\nLugar de Nacimiento : " + docente.LugarNac +
            "\nFecha de Nacimiento: " + docente.FechaNac + "\nAFP : " + docente.Afp +
            "\nProfesion : " + docente.Facultad + "\nCursos : " + docente.Cursos);
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
