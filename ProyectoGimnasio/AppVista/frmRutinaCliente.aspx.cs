using ProyectoGimnasio.AppControlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGimnasio.AppVista
{
    public partial class frmRutinaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DetalleRutinaDAO detalle = new DetalleRutinaDAO();
            detalle.getOne(1);
            gvDetalleRutina.DataSource = detalle.getOne(1);
            gvDetalleRutina.DataBind();
        }
    }
}