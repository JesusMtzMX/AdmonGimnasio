<%@ Page Title="" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmAdministracionRutinas.aspx.cs" Inherits="ProyectoGimnasio.AppVista.Administracion.frmAdministracionRutinas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.23/css/jquery.dataTables.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="container mx-5 mt-5">
            <div class="d-inline-block col-7 me-5">
                <asp:GridView ID="gvGruposMusc" class="table table-striped table-bordered table-dark" runat="server">

                </asp:GridView>
            </div> <!-- // tabla grupos musculares -->
            
            <div class="d-inline-block col-4 align-top">
                <h5>Agregar grupo muscular</h5>
                <asp:TextBox type="number" class="form-control mb-1" ID="txtIDGrupoMusc" placeholder="ID" runat="server" />
                <asp:TextBox class="form-control mb-1" ID="txtNombreGrupoMusc" placeholder="Nombre" runat="server" />
                <asp:Button class="btn btn-success" ID="btnAgregarGrupo" Text="Agregar" runat="server" OnClick="btnAgregarGrupo_Click"/>
                <asp:Button class="btn btn-secondary" ID="btnEditarGrupo" Text="Editar" runat="server" OnClick="btnEditarGrupo_Click"/>
                <asp:Button class="btn btn-danger" ID="btnEliminarGrupo" Text="Eliminar" runat="server" OnClick="btnEliminarGrupo_Click"/>
            </div> <!-- // form agregar grupo -->

            <div class="my-5"></div>

            <div class="d-inline-block col-7 me-5">
                <asp:GridView ID="gvEjercicios" class="table table-striped table-bordered table-dark" runat="server">

                </asp:GridView>
            </div> <!-- // tabla ejercicios-->

            <div class="d-inline-block col-4 align-top">
                <h5>Agregar ejercicio</h5>
                <asp:TextBox type="number" class="form-control mb-1" ID="txtIDEjercicio" placeholder="ID" runat="server" />
                <asp:TextBox class="form-control mb-1" ID="txtNombreEjercicio" placeholder="Nombre" runat="server" />
                <asp:DropDownList CssClass="form-control" ID="ddlListaGrupoMusc" runat="server">                    
                </asp:DropDownList>
                <asp:Button class="btn btn-success mt-2" ID="btnAgregarEjercicio" Text="Agregar ejercicio" runat="server" OnClick="btnAgregarEjercicio_Click" />
                <asp:Button class="btn btn-secondary" ID="btnEditarEjercicio" Text="Editar" runat="server" OnClick="btnEditarEjercicio_Click"/>
                <asp:Button class="btn btn-danger" ID="btnEliminarEjercicio" Text="Eliminar" runat="server" OnClick="btnEliminarEjercicio_Click"/>
            </div> <!-- // form ejercicio -->

        </div> <!-- // Container -->

        <asp:Label ID="labelEstatus" Text="text" runat="server" />

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js" integrity="sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=" crossorigin="anonymous"></script>
    <script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.23/js/jquery.dataTables.js"></script>
    <!--<script src="JS/bootstrapValidator.js"></script>-->
    <script src="../JS/admonRutinas.js"></script>
    <script src="../JS/tablaEjercicios.js"></script>
</asp:Content>
