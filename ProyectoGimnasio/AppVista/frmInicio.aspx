<%@ Page Title="" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Página de inicio</title>
    <link href="CSS/inicio_style.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="jumbotron">
        <h1 class="text-center">Bienvenido a Central GYM</h1>        
    </div>
    <div class="container pt-4">
        <div class="text-center">
            <h4>Un centro deportivo con profesionales en el entrenamiento físico</h4>
            <img class="w-75" src="https://images.pexels.com/photos/221247/pexels-photo-221247.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940" alt="Alternate Text" />
        </div>
    </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <script src="JS/inicio_js.js"></script>
</asp:Content>
