using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Persona 
    {
        private string codigo;
        private string apellidos;
        private string nombres;
        private string correo;
        private string domicilio;
        private DateTime fechaNac;
        private string lugarNac;
        private string numeroCel;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string LugarNac { get => lugarNac; set => lugarNac = value; }
        public string NumeroCel { get => numeroCel; set => numeroCel = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }

        public string Asistir()
        {
            return "Este metodo no se a implementado todabia";
        }
        public string Existir()
        {
            return "Este metodo no se a implementado todabia";
        }
    }
}
