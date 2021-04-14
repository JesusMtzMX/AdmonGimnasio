using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class DetalleRutina
    {
        private int Series { get; set; }
        private int Repeticiones { get; set; }

        public DetalleRutina(int Series, int Repeticiones)
        {
            this.Series = Series;
            this.Repeticiones = Repeticiones;
        }
    }
}