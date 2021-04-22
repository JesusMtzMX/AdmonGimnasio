// función que asigna el evento clic al botón para llamar al método dtProductos
function __showProducts() {
    $("#btn-carga").on("click", function () {
        dtProductos(); 
    });
}

// llenado de la tabla con id #tabla-productos, usando el plugin de DataTables
function dtProductos() {
    var table = $("#tabla-productos").DataTable({
        destroy: true,
        responsive: true,
        ajax: {     //Datatables usa Jquery, por lo que tiene incorporado AJAX para cargar datos
            method: "POST",
            url: "frmAdministrarProductos.aspx/obtenerProductos", //llama al web method de la ruta
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: function (d) {
                return JSON.stringify(d); //convierte json a string
            },
            dataSrc: "d.data" //usa la data (convertida a string) del json como fuente de datos para llenar la tabla
        },
        columns: [
            { "data": "idProducto" },
            { "data": "Nombre" },
            { "data": "Marca" },
            { "data": "Contenido" },
            { "data": "Categoria" },
            { "data": "Descripcion" },
            { "data": "Foto" },
            { "data": "Estatus" }
        ]
    });
}

function test() {
    $.ajax({
        method: "POST",
        url: "frmAdministrarProductos.aspx/obtenerProductos",
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    }).done(function (info) {
        console.log(info);
    });
}

