using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevasCarrerasApp1.Dominio
{
    internal class Carrera
    {
      
        public int CarreraNro { get; set; }
        public string Nombre { get; set; }

    
        public List<DetalleCarrera> Detalles { get; set; }

        public Carrera()
        {
            Detalles = new List<DetalleCarrera>();
        }

        public void AgregarDetalle(DetalleCarrera detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }

    }
}
