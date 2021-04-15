<%@ Page Title="" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-3">
        <h3>Productos</h3>
        <p>A continuación se muestran los productos disponibles en nuestro gimnasio</p>

        <div>
            <div id="carouselExampleControls" class="carousel slide w-50 m-auto" data-ride="carousel">
              <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="d-block w-100" src="IMG/img-barra-pesas.jpg" alt="First slide">
                </div>
                <div class="carousel-item">
                    <img class="d-block w-100" src="IMG/img-barra-pesas.jpg" alt="Second slide">
                </div>
                <div class="carousel-item">
                    <img class="d-block w-100" src="IMG/img-barra-pesas.jpg" alt="Third slide">
                </div>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
                </a>
            </div>
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="JS/productos.js"></script>
</asp:Content>
