<%@ Page Title="Registrar Cliente" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmRegistroCliente.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmRegistrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="container border rounded bg-dark my-4 text-center">
            <h4 class="text-info"> Complete los campos que a continuación se solicitan </h4>            
        </div>
        <div class="container bg-light font-weight-bold border border-dark rounded py-4">
            <div>
                <p class="font-weight-normal text-black-50">Información personal</p>
            </div>
            <div class="form-row"> <!-- Datos -->
                <div class="form-group col-md">
                    <asp:Label ID="lblNombre" CssClass="col-form-label text-dark" Text="Nombre" runat="server" />
                    <asp:TextBox ID="txtNombre" CssClass="form-control" TextMode="SingleLine" runat="server" />                    
                </div>
                <div class=" form-group col-md flex-column">
                    <asp:Label ID="lblApellidos" CssClass="col-form-label text-dark" Text="Apellidos" runat="server" />
                    <asp:TextBox ID="txtApellidos" CssClass="form-control" TextMode="SingleLine" runat="server" />
                </div>
            </div>
            <div class="form-row">
                <div class=" form-group col-md flex-column">
                    <asp:Label ID="lblEdad" CssClass="col-form-label text-dark" Text="Edad (años)" runat="server" />
                    <asp:TextBox ID="txtEdad" CssClass="form-control" TextMode="Number" MaxLength="2" runat="server" />                    
                </div>
                <div class="form-group col-md flex-column">
                    <asp:Label ID="lblPeso" CssClass="col-form-label text-dark" Text="Peso (kg)" runat="server" />
                    <asp:TextBox ID="txtPeso" CssClass="form-control" TextMode="Number" MaxLength="3" runat="server" />
                </div>
                <div class="form-group col-md flex-column">
                    <asp:Label ID="lblEstatura" CssClass="col-form-label text-dark" Text="Estatura (cms)" runat="server" />
                    <asp:TextBox ID="txtEstatura" CssClass="form-control" TextMode="Number" MaxLength="3" runat="server" />
                </div>
            </div>
            <div>
                <p class="font-weight-normal text-black-50">Datos con los que accederá al sistema</p>
            </div>
            <div class="form-row">
                <div class=" form-group col-md flex-column">
                    <asp:Label ID="lblEmail" CssClass="col-form-label text-dark" Text="Email" runat="server" />
                    <asp:TextBox ID="txtEmail" CssClass="form-control" TextMode="Email" runat="server" />                    
                </div>
                <div class="form-group font-weight-normal col-md flex-column">
                    <asp:Label ID="lblClave" CssClass="col-form-label font-weight-bold text-dark" Text="Clave de acceso" runat="server" />
                    <asp:TextBox ID="txtClave" CssClass="form-control" TextMode="Password" runat="server" />
                </div>
            </div> <!-- /Datos -->
            <div class="form-row">
                <div class="mt-3">
                    <asp:Button ID="btnAceptar" CssClass="btn btn-dark btn-outline-success font-weight-bold mr-4" Text="REGISTRAR" runat="server" />
                    <asp:Button ID="btnCancelar" CssClass="btn btn-dark btn-outline-danger" Text="CANCELAR" runat="server" />
                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">    
    <script src="JS/clienteRegistroCliente.js"></script>
</asp:Content>
