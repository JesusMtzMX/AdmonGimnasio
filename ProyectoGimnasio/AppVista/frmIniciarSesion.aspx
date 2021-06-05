<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmIniciarSesion.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmIniciarSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Iniciar sesión - The Central GYM</title>
    <meta lang="es-mx"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous"/>
    <script src="https://kit.fontawesome.com/a67dc84222.js" crossorigin="anonymous"></script>
    <link href="CSS/login_style.css" rel="stylesheet" />
</head>
<body class="">
    <!-- Barra de Navegación -->
    <nav class="navbar navbar-dark bg-dark">
        <a class="navbar-brand" href="frmInicio.aspx">
            <img src="IMG/LogoGYM.png" width="30" height="30" class="d-inline-block align-top" alt="Central GYM"/>
            <span>Central GYM</span>            
        </a>
        <h4>
            <b class="text-light">Login</b>
        </h4>
        <form class="form-inline">
            <button class="btn btn-sm border-secondary rounded-pill btn-outline-info mr-4" onclick="window.location.href='frmInicio.aspx'" type="button">
                Regresar
            </button>
        </form>
    </nav>

    <!-- Formulario de inicio de sesión -->
    <form id="frmLogin" runat="server">
        <div class="container text-center mt-5 mb-3">
            <h3 >Ingresa tus datos para iniciar sesión</h3>
        </div>        
        <div class="container w-75 mt-2 text-center px-0 pt-5 pb-4 alert alert-primary rounded">        
            <div class="form__section">            
                <asp:TextBox type="email" ID="txtEmail" TextMode="Email" autocomplete="off" class="form__input" placeholder="Email" runat="server" />
            </div>
            <div class="form__section">            
                <asp:TextBox type="password" ID="txtClaveAcceso" class="form__input" placeholder="Clave de acceso" runat="server" />
            </div>           
            <div class="form__section">            
                <asp:Button Text="Iniciar sesión" ID="btnIngresar" CssClass="btn-login btn border border-info w-50 mt-4 py-2 font-weight-bold text-dark" runat="server" />
            </div>
        </div>
        <div class="container w-75 mt-2 rounded">
            <div class="alert alert-danger" id="alerta-error" role="alert" hidden="hidden">
                <i class="fas fa-exclamation-circle">&nbsp</i><b>Datos incorrectos.</b> Por favor, revise su información ingresada.
            </div>
            <div class="alert alert-success" id="alerta-usuario" role="alert" hidden="hidden">
                <i class="fas fa-check-circle">&nbsp</i><b>Bienvenido.</b> Redirigiendo a su perfil...
            </div>
        </div>
        <div class="container mt-5">
            <div class="text-center pb-3">
                <h5 class="small">Si aún no tienes cuenta, puedes crearla de forma gratuita</h5>
            </div>
            <div class="container text-center">
                <button type="button" class="btn btn-sm btn-primary rounded rounded-pill mx-auto" id="btnCrearCuenta" onclick="gotoCrearCuenta()">
                    <span class="font-weight-bold">CREAR CUENTA</span>
                </button>
            </div>            
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.5.1.min.js" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-Piv4xVNRyMGpqkS2by6br4gNJ7DXjqk09RmUpJ8jgGtD7zP9yug3goQfGII0yAns" crossorigin="anonymous"></script>

    <script src="JS/bootstrapValidator.js"></script>
    <script src="JS/login.js"></script>
</body>
</html>
