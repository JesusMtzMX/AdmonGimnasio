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
                Usuario u = al.iniciarSesion(txtEmail.Text.Trim(), txtClaveAcceso.Text);

                if (u != null)
                {
                    Session["EmailUsuario"] = u.Email.ToString();
                    Session["TipoUsuario"] = al.getTipoUsuario(u.idUsuario).ToString();
                    txtSession.Text = u.idUsuario+"";
                    //Response.Redirect("frmInicio.aspx");
                }
                else
                {
                    //divMensaje.Visible = true;
                    Session["TipoUsuario"] = "Datos no válidos";
                    txtSession.Text = Session["TipoUsuario"].ToString();
                    //Response.Redirect("frmAyuda.aspx");
                }

                
            }
            catch (Exception ex)
            {
                //divMensaje.Visible = true;
            }
        }

    }
}