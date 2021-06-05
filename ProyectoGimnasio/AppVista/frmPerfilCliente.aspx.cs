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
    public partial class frmPerfilCliente : System.Web.UI.Page
    {
        ClienteDAO clientedao = new ClienteDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            Cliente cliente = clientedao.getOne(1);

            lblNombreUsuarioCliente.Text = cliente.Nombre;
            lblApellidosUsuarioCliente.Text = cliente.Apellidos;
            lblEdadCliente.Text = cliente.Edad.ToString();
            lblPesoCliente.Text = cliente.Peso.ToString();
            lblEstaturaCliente.Text = cliente.Estatura.ToString();            
        }
    }
}