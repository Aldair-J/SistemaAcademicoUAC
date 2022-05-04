using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Alumno : Persona, IMantenimiento
    {
        private string carrera;
        private string escuela;
        private string seguro;

        public string Carrera { get => carrera; set => carrera = value; }
        public string Escuela { get => escuela; set => escuela = value; }
        public string Seguro { get => seguro; set => seguro = value; }

        public Persona Persona
        {
            get => default;
            set
            {
            }
        }

        public string Estudiar()
        {
            return "este metodo no a sido implementado";
        }
        public string Aprobar()
        {
            return "este metodo no a sido implementado";
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public bool Limpiar()
        {
            throw new NotImplementedException();
        }

        public bool Buscar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }
    }
}
