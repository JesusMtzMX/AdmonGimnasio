<%@ Page Title="Mi perfil - The Central GYM" Language="C#" MasterPageFile="~/AppVista/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="frmPerfilCliente.aspx.cs" Inherits="ProyectoGimnasio.AppVista.frmPerfilCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="container mt-4">
        <h3>Perfil de usuario</h3>
        <hr />
    </div>
    <div class="container mt-2 mb-3">
        <div class="row">
            <div class="col-sm-7">
                <div class="mb-3">
                    <h5>Nombre</h5>
                    <asp:Label ID="lblNombreUsuarioCliente" Text="Nombre" runat="server" />
                </div>
                <div class="mb-3">
                    <h5>Apellidos</h5>
                    <asp:Label ID="lblApellidosUsuarioCliente" Text="Apellidos" runat="server" />
                </div>
                <div class="mb-3">
                    <h5>Edad</h5>
                    <asp:Label ID="lblEdadCliente" Text="Edad" runat="server" />
                </div>
                <div class="mb-3">
                    <h5>Peso</h5>
                    <asp:Label ID="lblPesoCliente" Text="Peso" runat="server" />
                </div>
                <div class="mb-3">
                    <h5>Estatura</h5>
                    <asp:Label ID="lblEstaturaCliente" Text="Estatura" runat="server" />
                </div>
            </div>
            <div class="col-sm-5">
                <div class="mb-3">
                    <h5>Entrenador asignado</h5>
                    <asp:Label ID="Label1" Text="Estatura" runat="server" />
                </div>
                <div class="mb-3">
                    <h5>Mi rutina</h5>
                    <button id="btnVerRutina" class="btn btn-dark" onclick="location.href = frmRutinaCliente.aspx ">
                        Ver mi rutina</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
