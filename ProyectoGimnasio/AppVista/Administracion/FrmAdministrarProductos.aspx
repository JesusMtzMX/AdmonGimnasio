<%@ Page Title="" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmAdministrarProductos.aspx.cs" Inherits="ProyectoGimnasio.AppVista.Administracion.FrmAdministrarProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.24/css/jquery.dataTables.css">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="container mt-3">
        <div class="bg-dark text-white text-center p-3">
            <h4>Administración de productos</h4>
        </div>
        <div>
            <a href="../frmProductos.aspx">Ver página principal de productos</a>            
        </div>
        <div>
            <button type="button" id="btn-carga" class="btn btn-success">
                Mostrar productos
            </button>
        </div>
        <div class="mt-5 bg-light">
            <table id="tabla-productos" class="table table-stripped">
                <thead>
                    <tr>
                        <th>idProducto</th>
                        <th>Nombre</th>
                        <th>Marca</th>
                        <th>Contenido</th>
                        <th>Categoria</th>
                        <th>Descripcion</th>
                        <th>Foto</th>
                        <th>Estatus</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        
                    </tr>                    
                </tbody>
            </table>
        </div>
        <div class="mt-5">
            <asp:GridView runat="server">

            </asp:GridView>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.24/js/jquery.dataTables.js"></script>
    <script src="../JS/administrarProductos.js"></script>
     <script>
        $(function () {                        
            __showProducts();
        });
     </script>
</asp:Content>
