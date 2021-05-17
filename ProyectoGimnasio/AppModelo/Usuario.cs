using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }

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