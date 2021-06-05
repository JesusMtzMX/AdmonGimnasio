<%@ Page Title="Mi Rutina - The Central GYM" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmRutinaCliente.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmRutinaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="container mt-4">
        <h3>Mi rutina</h3>
        <hr />
    </div>
    <div class="container mt-3 mb-5">
        <div class="row">
            <h5>Rutina asignada por:</h5>
        </div>
        <div class="table-responsive p-2 shadow rounded-lg">
            <asp:GridView ID="gvDetalleRutina" CssClass="table table-dark table-striped table-hover" runat="server">

            </asp:GridView>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
