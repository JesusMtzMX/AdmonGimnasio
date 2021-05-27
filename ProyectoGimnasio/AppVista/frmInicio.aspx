<%@ Page Title="" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Página de inicio</title>
    <link href="CSS/inicio_style.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="jumbotron bg-transparent pt-4 pb-0">
        <h1 class="text-center">Bienvenido a <span class="font-weight-bold text-dark">The Central GYM</span></h1>
    </div>
    <div class="container pt-0 mb-5">
        <div class="card bg-transparent" style="width: 50%; margin: auto">
            <img class="card-img-top" src="IMG/LogoGYM.png" />            
        </div>
        <br />
        <h3 class="card-text text-center font-weight-bolder">
            Un centro deportivo con profesionales en el entrenamiento físico
        </h3>
    </div>
    <hr />
    <div class="container pt-3">      
        <h4>¿Qué esperas para unirte?</h4>        
        <p>
            En nuestras instalaciones, encontrarás una gran variedad de máquinas y equipo para fortalecer
            todo tu cuerpo, trabajando cada uno de los músculos con las mejores rutinas que nuestros
            entrenadores han diseñado específicamente para ti.
        </p>
    </div>

    <!-- Carrusel de imágenes -->
    <div class="container w-50 my-5">
        <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="d-block w-100 rounded" src="https://images.pexels.com/photos/1954524/pexels-photo-1954524.jpeg?auto=compress&cs=tinysrgb&dpr=3&h=750&w=1260" alt="First slide">
                </div>
                <div class="carousel-item">
                    <img class="d-block w-100 rounded" src="https://images.pexels.com/photos/1552252/pexels-photo-1552252.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940" alt="Second slide">
                </div>
                <div class="carousel-item">
                    <img class="d-block w-100 rounded" src="https://images.pexels.com/photos/3926636/pexels-photo-3926636.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940" alt="Third slide">
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
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <script src="JS/inicio_js.js"></script>
</asp:Content>
