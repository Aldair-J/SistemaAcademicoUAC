using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Regular : Persona, IMantenimiento
    {
        private string creditos;
        private string cursus;
        private string notas;
        private string semestre;

        public string Creditos { get => creditos; set => creditos = value; }
        public string Cursos { get => cursus; set => cursus = value; }
        public string Notas { get => notas; set => notas = value; }
        public string Semestre { get => semestre; set => semestre = value; }

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
