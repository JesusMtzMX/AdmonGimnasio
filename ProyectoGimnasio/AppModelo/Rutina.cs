using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Rutina
    {
        private int idRutina { get; set; }
        private String FechaInicio { get; set; }
        private String FechaFinalizacion { get; set; }
        private int idInscripcion { get; set; }

        public Rutina()
        {

        }

        public Rutina(int idRutina, String FechaInicio, String FechaFinalizacion, int idInscripcion)
        {
            this.idRutina = idRutina;
            this.FechaInicio = FechaInicio;
            this.FechaFinalizacion = FechaFinalizacion;
            this.idInscripcion = idInscripcion;
        }

        public Rutina(String FechaInicio, String FechaFinalizacion, int idInscripcion)
        {
            this.FechaInicio = FechaInicio;
            this.FechaFinalizacion = FechaFinalizacion;
            this.idInscripcion = idInscripcion;
        }

    }
}