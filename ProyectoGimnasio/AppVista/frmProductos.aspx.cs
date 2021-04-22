﻿using ProyectoGimnasio.AppControlador;
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
            gvProductos.DataSource = __Conexion.ejecutarConsulta
                (new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM productos"));
            gvProductos.DataBind();
        }
    }
}