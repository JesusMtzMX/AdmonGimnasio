using ProyectoGimnasio.AppControlador;
using ProyectoGimnasio.AppModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGimnasio.AppVista
{
    public partial class frmIniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(EnableSession = true)]
        public static string GetUsuario(Usuario objUsuario)
        {
            UsuarioDAO usuariodao = new UsuarioDAO();
            Usuario user = usuariodao.iniciarSesion(objUsuario.Email, objUsuario.Clave);

            if (user != null)
            {
                string usuario = usuariodao.getTipoUsuario(user.idUsuario);
                HttpContext.Current.Session["TipoUsuario"] = usuario;
                return usuario;
            }
            return "Usuario no encontrado";
        }
        
    }
}