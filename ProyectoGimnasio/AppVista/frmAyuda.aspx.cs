using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGimnasio.AppVista
{
    public partial class frmAyuda : System.Web.UI.Page
    {
        wsCalculadora.CalculatorSoapClient calculadora
                = new wsCalculadora.CalculatorSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = calculadora.Add(
                Convert.ToInt32(txtNumeroUno.Text), Convert.ToInt32(txtNumeroDos.Text)).ToString();
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = calculadora.Subtract(
                Convert.ToInt32(txtNumeroUno.Text), Convert.ToInt32(txtNumeroDos.Text)).ToString();
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = calculadora.Multiply(
                Convert.ToInt32(txtNumeroUno.Text), Convert.ToInt32(txtNumeroDos.Text)).ToString();
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            if(txtNumeroDos.Text == "0" || txtNumeroDos.Text == "")
            {
                lblResultado.Text = "Error por división entre 0";                
                return;
            }

            lblResultado.Text = calculadora.Divide(
                Convert.ToInt32(txtNumeroUno.Text), Convert.ToInt32(txtNumeroDos.Text)).ToString();
        }
    }
}