using ProyectoGimnasio.AppControlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoGimnasio.AppVista
{
    public partial class frmProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        public void cargarProductos()
        {
            ServiceReference1.wsProductosSoapClient ws = new ServiceReference1.wsProductosSoapClient();
            gvProductos.DataSource = ws.GetProducts();
            gvProductos.DataBind();
        }
    }
}