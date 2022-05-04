using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    interface IMantenimiento
    {
        bool Agregar();
        bool Limpiar();
        bool Buscar();
        bool Eliminar();
    }
}
