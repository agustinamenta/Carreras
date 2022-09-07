using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevasCarrerasApp1.Dominio
{
    internal class Asignatura
    {
        public Asignatura(int asignaturaNombre, string nombre)
        {
            AsignaturaNro = asignaturaNombre;
            Nombre = nombre;
        }

        public int AsignaturaNro { get; set; }
        public string Nombre { get; set; }

        public Asignatura()
        {
            AsignaturaNro = 0;
            Nombre = "";
        }
        public override string ToString()
        {
            return "Nombre de Asignatura: " + Nombre;
        }
    }
}
