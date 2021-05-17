using ProyectoGimnasio.AppControlador;
using ProyectoGimnasio.AppModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGimnasio.AppVista
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //Verificar los datos que llegan del cliente
            UsuarioDAO al = new UsuarioDAO();
            try
            {
                Usuario u = al.iniciarSesion(txtEmail.Text.Trim(), txtClaveAcceso.Text.Trim());
                if (u != null)
                {                    
                    Session["email_usuario"] = u.Email;
                    Response.Redirect("frmInicio.aspx");
                }
                else
                {
                    //divMensaje.Visible = true;
                    Session["tipo_usuario"] = "";
                    Response.Redirect("frmAyuda.aspx");
                }
            }
            catch (Exception ex)
            {
                //divMensaje.Visible = true;
            }
        }

    }
}