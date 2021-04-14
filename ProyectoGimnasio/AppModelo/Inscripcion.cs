using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Inscripcion
    {
        private int idInscripcion { get; set; }
        private String FechaInicio { get; set; }
        private String FechaRenovacion { get; set; }
        private String Estatus { get; set; }

        public Inscripcion(String FechaInicio, String FechaRenovacion, String Estatus)
        {
            this.FechaInicio = FechaInicio;
            this.FechaRenovacion = FechaRenovacion;
            this.Estatus = Estatus;
        }
    } 
}