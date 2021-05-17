using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class EntrenadorCliente
    {
        private int idEntrenador { get; set; }
        private int idCliente { get; set; }

        public EntrenadorCliente()
        {

        }

        public EntrenadorCliente(int idEntrenador, int idCliente)
        {
            this.idEntrenador = idEntrenador;
            this.idCliente = idCliente;
        }
    }
}