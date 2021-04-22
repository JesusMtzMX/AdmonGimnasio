using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppModelo
{
    public class Producto
    {
        public int idProducto { get; set; }
        public String Nombre { get; set; }
        public String Marca { get; set; }
        public String Contenido { get; set; }
        public String Categoria { get; set; }
        public String Descripcion { get; set; }
        public String Foto { get; set; }
        public String Estatus { get; set; }

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

        public Producto()
        {

        }

    }
}