using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Ejercicio
    {
        private int idEjercicio { get; set; }
        private String Nombre { get; set; }
        private String GrupoMuscular { get; set; }
        private String Foto { get; set; }

        public Ejercicio()
        {

        }

        public Ejercicio(int idEjercicio, String Nombre, String GrupoMuscular, String Foto)
        {
            this.idEjercicio = idEjercicio;
            this.Nombre = Nombre;
            this.GrupoMuscular = GrupoMuscular;
            this.Foto = Foto;
        }

        public Ejercicio(String Nombre, String GrupoMuscular, String Foto)
        {            
            this.Nombre = Nombre;
            this.GrupoMuscular = GrupoMuscular;
            this.Foto = Foto;
        }

    }
}