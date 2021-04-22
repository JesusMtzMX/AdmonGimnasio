using ProyectoGimnasio.AppControlador;
using ProyectoGimnasio.AppModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGimnasio.AppVista.Administracion
{
    public partial class FrmAdministrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        [WebMethod] //El web method será llamado desde AJAX para obtener la información
        public static object obtenerProductos() //método que retorna una lista de tipo Producto
        {
            List<Producto> lista = new List<Producto>();
            ProductoDAO productos = new ProductoDAO();

            lista = productos.getAll();

            object json = new { data = lista };

            return json;
        }
    }
}