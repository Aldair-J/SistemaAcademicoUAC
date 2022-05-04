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
    /// Lógica de interacción para Regular.xaml
    /// </summary>
    public partial class Regular : Window
    {
        public Regular()
        {
            InitializeComponent();
        }
        static CapaNegocios.Regular regular = new CapaNegocios.Regular();
        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            regular.Nombres = txtnombres.Text.Trim();
            regular.Apellidos = txtapellidos.Text.Trim();
            regular.Codigo = txtcodigo.Text.Trim();
            regular.Correo = txtcorreo.Text.Trim();
            regular.Domicilio = txtdomicilio.Text.Trim();
            regular.LugarNac = txtlugarNac.Text.Trim();
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            regular.FechaNac = FechaNac.Value;
            regular.Creditos = txtcreditos.Text.Trim();
            regular.Cursos = txtcursos.Text.Trim();
            regular.Notas = txtnotas.Text.Trim();
            regular.Semestre = txtsemestre.Text.Trim();
            MessageBox.Show("Se ingresaron los datos correctamente");


        }

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\nNombres: " + regular.Nombres + "Apellidos: " + regular.Apellidos +
                "\nCodigo: " + regular.Codigo + "\nCorreo: " + regular.Correo +
                "\nDomicilio: " + regular.Domicilio + "\nLugar de Nacimiento: " + regular.LugarNac +
                "\nFecha de Nacimiento: " + regular.FechaNac + "\nCreditos: " + regular.Creditos +
                "\nCursos :"+regular.Cursos+ "\nNotas :"+regular.Notas+ "\nsemestre :" +regular.Semestre);
                
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
