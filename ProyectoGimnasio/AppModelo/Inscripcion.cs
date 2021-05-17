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
        private int idCliente { get; set; }

        public Inscripcion()
        {

        }

        public Inscripcion(int idInscripcion, String FechaInicio, String FechaRenovacion, String Estatus,
            int idCliente)
        {
            this.idInscripcion = idInscripcion;
            this.FechaInicio = FechaInicio;
            this.FechaRenovacion = FechaRenovacion;
            this.Estatus = Estatus;
            this.idCliente = idCliente;
        }

        public Inscripcion(String FechaInicio, String FechaRenovacion, String Estatus, int idCliente)
        {
            this.FechaInicio = FechaInicio;
            this.FechaRenovacion = FechaRenovacion;
            this.Estatus = Estatus;
            this.idCliente = idCliente;
        }
    } 
}