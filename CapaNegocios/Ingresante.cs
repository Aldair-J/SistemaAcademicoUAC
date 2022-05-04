using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Ingresante : Persona, IMantenimiento
    {
        private string fechaIng;
        private string metodoIngre;
        private string puesto;

        public string FechaIng { get => fechaIng; set => fechaIng = value; }
        public string MetodoIngre { get => metodoIngre; set => metodoIngre = value; }
        public string Puesto { get => puesto; set => puesto = value; }

        public Alumno Alumno
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
