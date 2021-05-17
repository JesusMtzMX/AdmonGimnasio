using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class DetalleRutina
    {
        private int idRutina { get; set; }
        private int idEjercicio { get; set; }
        private int Series { get; set; }
        private int Repeticiones { get; set; }

        public DetalleRutina()
        {

        }

        public DetalleRutina(int idRutina, int idEjercicio, int Series, int Repeticiones)
        {
            this.idRutina = idRutina;
            this.idEjercicio = idEjercicio;
            this.Series = Series;
            this.Repeticiones = Repeticiones;
        }
    }
}