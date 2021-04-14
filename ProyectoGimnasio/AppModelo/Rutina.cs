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

        public Rutina(String FechaInicio, String FechaFinalizacion)
        {
            this.FechaInicio = FechaInicio;
            this.FechaFinalizacion = FechaFinalizacion;
        }

    }
}