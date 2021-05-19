using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGimnasio.AppVista
{
    public partial class frmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Cuando se carga la página por primera vez (sin form o sin recargar)
            {
                if (Session["TipoUsuario"] == null || Session["TipoUsuario"].ToString() == "")
                {
                    //Response.Redirect("frmLogin.aspx");
                }
            }
        }
    }
}