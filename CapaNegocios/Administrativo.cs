using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Administrativo : Persona, IMantenimiento
    {
        private string especialidad;
        private string experiencia;
        private string turno;

        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Experiencia { get => experiencia; set => experiencia = value; }
        public string Turno { get => turno; set => turno = value; }

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
