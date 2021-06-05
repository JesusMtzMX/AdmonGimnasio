using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public double Estatura { get; set; }
        public String Foto { get; set; }
        public int idUsuario { get; set; }

        public Cliente()
        {

        }
        public Cliente (int idCliente, String Nombre, String Apellidos, int Edad, double Peso,
            double Estatura, String Foto, int idUsuario)
        {
            this.idCliente = idCliente;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.Peso = Peso;
            this.Estatura = Estatura;
            this.Foto = Foto;
            this.idUsuario = idUsuario;
        }

        public Cliente(String Nombre, String Apellidos, int Edad, double Peso,
            double Estatura, String Foto, int idUsuario)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.Peso = Peso;
            this.Estatura = Estatura;
            this.Foto = Foto;
            this.idUsuario = idUsuario;
        }
    }
}