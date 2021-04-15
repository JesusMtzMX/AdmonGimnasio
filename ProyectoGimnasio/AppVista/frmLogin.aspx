<%@ Page Title="" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/login_style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <h3>A continuación ingrese sus datos para iniciar sesión</h3>
        <div class="form__section">
                <input type="email" class="form__input" placeholder="Email">
            </div>
            <div class="form__section">
                <input type="password" class="form__input" placeholder="Clave de acceso">
            </div>           
            <div class="form__section">
                <input type="submit" name="name" class="form__input" value="Ingresar" />
            </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="JS/login.js"></script>
</asp:Content>
