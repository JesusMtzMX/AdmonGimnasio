using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Entrenador
    {
        public int idEntrenador { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Domicilio { get; set; }
        public String Telefono { get; set; }
        public String Foto { get; set; }
        public int idUsuario { get; set; }

        public Entrenador()
        {

        }

        public Entrenador(int idEntrenador, String Nombre, String Apellidos, String Domicilio,
            String Telefono, String Foto, int idUsuario)
        {
            this.idEntrenador = idEntrenador;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Domicilio = Domicilio;
            this.Telefono = Telefono;
            this.Foto = Foto;
            this.idUsuario = idUsuario;
        }

        public Entrenador(String Nombre, String Apellidos, String Domicilio, String Telefono,
            String Foto, int idUsuario)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Domicilio = Domicilio;
            this.Telefono = Telefono;
            this.Foto = Foto;
            this.idUsuario = idUsuario;
        }

    }
}