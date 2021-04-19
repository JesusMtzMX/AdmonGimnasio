using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;
using System.Xml.Linq;

namespace ProyectoGimnasio.AppVista.Administracion
{
    public partial class frmAdministracionRutinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargarDDLDatosGruposM();
                this.cargarDatosEjercicios();
                this.cargarDatosGruposM();
                labelEstatus.Text = "Se cargó la página por primera vez";
                labelEstatus.CssClass = "bg-info text-dark";
            }
            else
            {
                labelEstatus.Text = "Se cargó la página con datos POST";
                labelEstatus.CssClass = "bg-info text-white";
            }
        }

        // Evento para agregar un nuevo grupo muscular a la lista
        protected void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            XDocument document;
            try
            {   // Se carga el archivo xml, y si no lo encuentra accede a crearlo en el catch
                document = XDocument.Load(Server.MapPath("gruposMusculares.xml"));
            }
            catch (Exception)
            {
                generarXMLGruposMusc();
                return;
            }

            XElement grupoMuscular = new XElement("GrupoMuscular");

            grupoMuscular.Add(new XElement("IDGrupoMuscular", txtIDGrupoMusc.Text));
            grupoMuscular.Add(new XElement("Nombre", txtNombreGrupoMusc.Text));

            document.Descendants("GruposMusculares").First().Add(grupoMuscular);

            using (XmlWriter writer = XmlTextWriter.Create(Server.MapPath("gruposMusculares.xml")))
            {
                document.Save(writer);
            }

            cargarDDLDatosGruposM();
            cargarDatosGruposM();
        }

        public void generarXMLGruposMusc() // Crear el archivo XML de los grupos musculares
        {
            XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", null));
            XElement root = new XElement("GruposMusculares");
            document.Add(root);

            XElement grupoMuscular = new XElement("GrupoMuscular");
            root.Add(grupoMuscular);

            grupoMuscular.Add(new XElement("IDGrupoMuscular", txtIDGrupoMusc.Text));
            grupoMuscular.Add(new XElement("Nombre", txtNombreGrupoMusc.Text));

            document.Save(Server.MapPath("gruposMusculares.xml"));

            cargarDDLDatosGruposM();
            cargarDatosGruposM();
        }

        public void cargarDatosGruposM()  //carga la tabla con los grupos musculares
        {
            try
            {
                using (DataSet ds = new DataSet())
                {
                    ds.ReadXml(Server.MapPath("gruposMusculares.xml"));
                    gvGruposMusc.DataSource = ds;
                    gvGruposMusc.DataBind();
                }
            }
            catch (Exception)
            {

            }
        }

        public void cargarDDLDatosGruposM() // Llena el DropDownList con los datos de grupos musculares
        {
            /*try
            {
                
            }
            catch (Exception)
            {
                labelEstatus.Text = "Entró en Catch de cargarDDLDatosGruposM :(";
                labelEstatus.CssClass = "bg-danger text-white";

            }*/

            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(Server.MapPath("gruposMusculares.xml"));
                ddlListaGrupoMusc.DataTextField = "Nombre";
                ddlListaGrupoMusc.DataValueField = "Nombre";
                ddlListaGrupoMusc.DataSource = ds;
                ddlListaGrupoMusc.DataBind();
            }

            ListItem li = new ListItem("Seleccionar grupo muscular...", "-1");
            ddlListaGrupoMusc.Items.Insert(0, li);

        }

        // Evento para agregar un nuevo ejercicio a la lista
        protected void btnAgregarEjercicio_Click(object sender, EventArgs e)
        {
            XDocument document;
            try
            {   // Carga el archivo XML, y si no lo encuentra accede al catch para crearlo
                document = XDocument.Load(Server.MapPath("ejercicios.xml"));
            }
            catch (Exception)
            {
                generarXMLEjercicios();
                return;
            }

            XElement ejercicio = new XElement("Ejercicio");

            ejercicio.Add(new XElement("IDEjercicio", txtIDEjercicio.Text));
            ejercicio.Add(new XElement("Nombre", txtNombreEjercicio.Text));
            ejercicio.Add(new XElement("GrupoMuscular", ddlListaGrupoMusc.SelectedValue));

            document.Descendants("Ejercicios").First().Add(ejercicio);

            using (XmlWriter writer = XmlTextWriter.Create(Server.MapPath("ejercicios.xml")))
            {
                document.Save(writer);
            }

            cargarDatosEjercicios();
        }

        public void generarXMLEjercicios() // Crea el archivo XML de los ejercicios
        {
            XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", null));
            XElement root = new XElement("Ejercicios");
            document.Add(root);

            XElement ejercicio = new XElement("Ejercicio");
            root.Add(ejercicio);

            ejercicio.Add(new XElement("IDEjercicio", txtIDEjercicio.Text));
            ejercicio.Add(new XElement("Nombre", txtNombreEjercicio.Text));
            ejercicio.Add(new XElement("GrupoMuscular", ddlListaGrupoMusc.SelectedValue));

            document.Save(Server.MapPath("ejercicios.xml"));

            cargarDatosEjercicios();

        }

        public void cargarDatosEjercicios() // Carga la tabla con los ejercicios
        {
            try
            {
                using (DataSet ds = new DataSet())
                {
                    ds.ReadXml(Server.MapPath("ejercicios.xml"));
                    gvEjercicios.DataSource = ds;
                    gvEjercicios.DataBind();
                }
            }
            catch (Exception)
            {

            }
        }

        protected void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            XDocument document = XDocument.Load(Server.MapPath("gruposMusculares.xml"));

            int index = 0;

            foreach (var node in document.Root.Elements("GrupoMuscular"))
            {
                string idGrupo = node.Element("IDGrupoMuscular").Value; //Obtiene el valor del ID

                if (idGrupo.Equals(txtIDGrupoMusc.Text)) //Si el ID coincide procede a usar el index
                {
                    break;
                }
                index++;
            }

            try
            {
                document.Root.Elements().ElementAt(index).Remove(); // elimina el elemento coincidente

                using (XmlWriter writer = XmlTextWriter.Create(Server.MapPath("gruposMusculares.xml")))
                {
                    document.Save(writer); //guarda el documento
                }
                cargarDatosGruposM();
                cargarDDLDatosGruposM();
            }
            catch (Exception)
            {


            }

        }

        protected void btnEditarGrupo_Click(object sender, EventArgs e) //Edita un elemento
        {
            XmlDocument document = new XmlDocument();
            document.Load(Server.MapPath("gruposMusculares.xml")); //carga el documento

            XmlNode node;
            node = document.DocumentElement;

            foreach (XmlNode node1 in node.ChildNodes)
            {
                if (node1.ChildNodes[0].InnerText == txtIDGrupoMusc.Text) // El el ID coincide edita según
                {                                                         // los campos editados
                    node1.ChildNodes[0].InnerText = txtIDGrupoMusc.Text;
                    node1.ChildNodes[1].InnerText = txtNombreGrupoMusc.Text;

                    document.Save(Server.MapPath("gruposMusculares.xml")); // guarda los cambios
                    cargarDatosGruposM();
                    cargarDDLDatosGruposM();
                    break;
                }
            }
        }
        protected void btnEliminarEjercicio_Click(object sender, EventArgs e) //Elimina un ejercicio
        {
            XDocument document = XDocument.Load(Server.MapPath("ejercicios.xml"));

            int index = 0;

            foreach (var node in document.Root.Elements("Ejercicio"))
            {
                string idGrupo = node.Element("IDEjercicio").Value; //Obtiene el valor del ID

                if (idGrupo.Equals(txtIDEjercicio.Text)) //Si el ID coincide procede a usar el index
                {
                    break;
                }
                index++;
            }

            try
            {
                document.Root.Elements().ElementAt(index).Remove(); // elimina el elemento coincidente

                using (XmlWriter writer = XmlTextWriter.Create(Server.MapPath("ejercicios.xml")))
                {
                    document.Save(writer); //guarda el documento
                }
                cargarDatosEjercicios();
            }
            catch (Exception)
            {


            }

        }

        protected void btnEditarEjercicio_Click(object sender, EventArgs e) //Edita un elemento
        {
            XmlDocument document = new XmlDocument();
            document.Load(Server.MapPath("ejercicios.xml")); //carga el documento

            XmlNode node;
            node = document.DocumentElement;

            foreach (XmlNode node1 in node.ChildNodes)
            {
                if (node1.ChildNodes[0].InnerText == txtIDEjercicio.Text) // El el ID coincide edita según
                {                                                         // los campos editados
                    node1.ChildNodes[0].InnerText = txtIDEjercicio.Text;
                    node1.ChildNodes[1].InnerText = txtNombreEjercicio.Text;
                    node1.ChildNodes[2].InnerText = ddlListaGrupoMusc.SelectedValue;

                    document.Save(Server.MapPath("ejercicios.xml")); // guarda los cambios
                    cargarDatosEjercicios();
                    break;
                }
            }
        }

    }
}