using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Entrenador
    {
        private int idEntrenador { get; set; }
        private String Nombre { get; set; }
        private String Apellidos { get; set; }
        private String Domicilio { get; set; }
        private String Telefono { get; set; }
        private String Foto { get; set; }

        public Entrenador(String Nombre, String Apellidos, String Domicilio, String Telefono, String Foto)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Domicilio = Domicilio;
            this.Telefono = Telefono;
            this.Foto = Foto;
        }

    }
}