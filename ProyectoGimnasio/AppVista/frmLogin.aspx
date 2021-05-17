<%@ Page Title="" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/login_style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="container mt-5">
        <h3>A continuación ingrese sus datos para iniciar sesión</h3>
        <div class="form__section">            
            <asp:TextBox type="email" ID="txtEmail" TextMode="Email" autocomplete="off" class="form__input" placeholder="Email" runat="server" />
        </div>
        <div class="form__section">            
            <asp:TextBox type="password" ID="txtClaveAcceso" class="form__input" placeholder="Clave de acceso" runat="server" />
        </div>           
        <div class="form__section">            
            <asp:Button Text="Ingresar" ID="btnIngresar" CssClass="form__input" OnClick="btnIngresar_Click" runat="server" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <script src="JS/login.js"></script>
</asp:Content>
