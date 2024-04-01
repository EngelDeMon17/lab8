using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class NotasAlumno
    {
        string nombre;
        List<int> nota;//para que el alumno almacene mas de una nota

        public string Nombre { get => nombre; set => nombre = value; }
        public List<int> Nota { get => nota; set => nota = value; }
    }
}
