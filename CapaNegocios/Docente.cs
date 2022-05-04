using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Docente : Persona, IMantenimiento
    {
        private string afp;
        private string cursos;
        private string facultad;

        public string Afp { get => afp; set => afp = value; }
        public string Cursos { get => cursos; set => cursos = value; }
        public string Facultad { get => facultad; set => facultad = value; }

        public Persona Persona
        {
            get => default;
            set
            {
            }
        }

        public bool Agregar()
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

        public bool Limpiar()
        {
            throw new NotImplementedException();
        }
    }
}
