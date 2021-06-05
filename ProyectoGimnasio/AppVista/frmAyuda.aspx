<%@ Page Title="" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmAyuda.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmAyuda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="container mt-3">
        <h3>Acerca de nosotros</h3>
        <p>A todos nuestros usuarios:</p>
        <p>
            Muchas gracias por su preferencia. The Central GYM es un centro deportivo que tiene
            como objetivo ofrecer un servicio de calidad, apoyando a toda aquella persona que está 
            empezando su camino de buenos hábitos para mejorar su aspecto físico, pero aún más importante,
            su <b>salud</b>.
        </p>
        <p>
            Nuestra prioridad eres tú. Es por ello que hacemos todo lo posible por brindarte la mejor
            atención, con los mejores entrenadores que te guiarán hacia tus metas.
        </p>
    </div>
    <div class="mb-5 pb-5">        
        <div class="container">
            <small>Easter egg (Calculadora web service)</small>
            <hr />
            <div class="mb-2">
                <asp:TextBox ID="txtNumeroUno" TextMode="Number" Text="0" CssClass="col-sm-4 form-control bg-transparent border-top-0 border-left-0 border-right-0 border-bottom border-dark" placeholder="Número 1" runat="server" />
            </div>
            <div>
                <asp:TextBox ID="txtNumeroDos" TextMode="Number" Text="0" CssClass="col-sm-4 form-control bg-transparent border-top-0 border-left-0 border-right-0 border-bottom border-dark" placeholder="Número 2" runat="server" />
            </div>
            <hr />
            <div class="mt-3 mb-3">
                <asp:Label ID="lblResultado" CssClass="col-sm-4 form-control bg-transparent border-top-0 border-left-0 border-right-0 border-bottom border-info" placeholder="Resultado" runat="server" />
            </div>
            <asp:Button ID="btnSumar" CssClass="btn btn-group-sm btn-primary" Text="Sumar" runat="server" OnClick="btnSumar_Click" />
            <asp:Button ID="btnRestar" CssClass="btn btn-group-sm btn-warning" Text="Restar" runat="server" OnClick="btnRestar_Click" />
            <asp:Button ID="btnMultiplicar" CssClass="btn btn-group-sm btn-success" Text="Multiplicar" runat="server" OnClick="btnMultiplicar_Click" />
            <asp:Button ID="btnDividir" CssClass="btn btn-group-sm btn-secondary" Text="Dividir" runat="server" OnClick="btnDividir_Click" />            
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <script src="JS/ayuda.js"></script>
</asp:Content>
