using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Usuario
    {
        private int idUsuario { get; set; }
        private string Email { get; set; }
        private string Clave { get; set; }

        public Usuario()
        {

        }
        
        public Usuario (int idUsuario, string Email, string Clave)
        {
            this.idUsuario = idUsuario;
            this.Email = Email;
            this.Clave = Clave;
        }

        public Usuario(string Email, string Clave)
        {
            this.idUsuario = idUsuario;
            this.Email = Email;
            this.Clave = Clave;
        }

    }
}