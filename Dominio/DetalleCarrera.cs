using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevasCarrerasApp1.Dominio
{
    internal class DetalleCarrera
    {
        public DetalleCarrera(Asignatura asignatura, int anioCursado, string cuatrimestre)
        {
            Asignatura = asignatura;
            AnioCursado = anioCursado;
            Cuatrimestre = cuatrimestre;

        }

        public Asignatura Asignatura { get; set; }
        public int AnioCursado { get; set; }
        public string Cuatrimestre { get; set; }
        public string Materia { get; set; }
        public DetalleCarrera(int anioCursado, string cuatrimestre, Asignatura asignatura)
        {
            this.AnioCursado = anioCursado;
            this.Cuatrimestre = cuatrimestre;
            
        }

        public override string ToString()
        {
            return "Año cursado: " + AnioCursado + " - Cuatrimestre: " + Cuatrimestre +
                " - Asignatura" + Materia.ToString();
        }
    }
}
