using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Producto
    {
        private int idProducto { get; set; }
        private String Nombre { get; set; }
        private String Marca { get; set; }
        private String Contenido { get; set; }
        private String Categoria { get; set; }
        private String Descripcion { get; set; }
        private String Foto { get; set; }
        private String Estatus { get; set; }

        public Producto(String Nombre, String Marca, String Contenido, String Categoria, String Descripcion, 
            String Foto, String Estatus)
        {
            this.Nombre = Nombre;
            this.Marca = Marca;
            this.Contenido = Contenido;
            this.Categoria = Categoria;
            this.Descripcion = Descripcion;
            this.Foto = Foto;
            this.Estatus = Estatus;
        }

    }
}