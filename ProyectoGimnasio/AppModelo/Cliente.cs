using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Cliente
    {
        private int idCliente { get; set; }
        private String Nombre { get; set; }
        private String Apellidos { get; set; }
        private int Edad { get; set; }
        private double Peso { get; set; }
        private double Estatura { get; set; }
        private String Foto { get; set; }

        public Cliente (String Nombre, String Apellidos, int Edad, double Peso, double Estatura, String Foto)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.Peso = Peso;
            this.Estatura = Estatura;
            this.Foto = Foto;
        }
    }
}