<%@ Page Title="Productos - The Central GYM" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="container mt-3">
        
        <div class="text-white bg-secondary text-center">
            <h3>Productos</h3>
            <p>A continuación se muestran los productos disponibles en nuestro gimnasio</p>
        </div>        
        <div class="table-responsive">
            <asp:GridView ID="gvProductos" class="table table-dark table-secondary" runat="server">
            </asp:GridView>
        </div>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <script src="JS/productos.js"></script>
</asp:Content>
