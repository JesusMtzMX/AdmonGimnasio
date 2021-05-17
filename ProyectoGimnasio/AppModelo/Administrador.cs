using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Administrador
    {
        private int idAdministrador { get; set; }
        private string Nombre { get; set; }
        private string Apellidos { get; set; }
        private string Domicilio { get; set; }
        private string Telefono { get; set; }
        private string Foto { get; set; }
        private int idUsuario { get; set; }

        public Administrador()
        {

        }

        public Administrador(int idAdministrador, string Nombre, string Apellidos, string Domicilio,
            string Telefono, string Foto, int idUsuario)
        {
            this.idAdministrador = idAdministrador;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Domicilio = Domicilio;
            this.Telefono = Telefono;
            this.Foto = Foto;
            this.idUsuario = idUsuario;
        }

        public Administrador(string Nombre, string Apellidos, string Domicilio,
            string Telefono, string Foto, int idUsuario)
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