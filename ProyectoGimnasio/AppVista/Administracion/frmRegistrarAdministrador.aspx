<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRegistrarAdministrador.aspx.cs" Inherits="ProyectoGimnasio.AppVista.Administracion.frmRegistrarAdministrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrador - Registrar usuario con privilegios de administración</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous"/>
</head>
<body>
    <nav class="navbar navbar-dark bg-dark">
        <a class="navbar-brand" href="../frmInicio.aspx">
            <img src="../IMG/LogoGYM.png" width="30" height="30" class="d-inline-block align-top" alt="Central GYM"/>
            <span>Central GYM</span>            
        </a>
        <h4>
            <b class="text-light">Registrar nuevo usuario administrador</b>
        </h4>
        <form class="form-inline">
            <button class="btn btn-sm border-secondary rounded-pill btn-outline-info mr-4" type="button">Regresar</button>            
        </form>
    </nav>
    <form id="frmRegistrarAdministrador" runat="server">
        <div class="container border rounded bg-dark mt-4 text-center">
            <h4 class="text-info"> Complete los campos que a continuación se solicitan </h4>            
        </div>
        <div class="container bg-light font-weight-bold border border-dark rounded py-4">
            <div>
                <p class="font-weight-normal text-black-50">Información personal y de contacto</p>
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
                    <asp:Label ID="lblDireccion" CssClass="col-form-label text-dark" Text="Dirección" runat="server" />
                    <asp:TextBox ID="txtDireccion" CssClass="form-control" TextMode="SingleLine" runat="server" />                    
                </div>
                <div class="form-group col-md flex-column">
                    <asp:Label ID="lblTelefono" CssClass="col-form-label text-dark" Text="Teléfono" runat="server" />
                    <asp:TextBox ID="txtTelefono" CssClass="form-control" TextMode="Phone" runat="server" />
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
    </form>

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>    
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-Piv4xVNRyMGpqkS2by6br4gNJ7DXjqk09RmUpJ8jgGtD7zP9yug3goQfGII0yAns" crossorigin="anonymous"></script>

    <script src="../JS/bootstrapValidator.js"></script>
    <script src="../JS/admonRegistrarAdministrador.js"></script>
</body>
</html>
