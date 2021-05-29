let formLogin = document.querySelector("#frmLogin");
//let liActive = document.querySelector("#iniciar-sesion");
let btnCrearCuenta = document.querySelector("#btnCrearCuenta");

//liActive.classList = "active-section";

gotoCrearCuenta = () => {
    location.href = 'frmRegistrarCliente.aspx';
}

formLogin.addEventListener('submit', (e) =>
{
    e.preventDefault();

    //alert('Submit');

    let formData = new FormData(formLogin);

    let usuario = {
        objUsuario: {
            email: formData.get('txtEmail'),
            clave: formData.get('txtClaveAcceso')
        }
    };

    console.log(formData.get('txtEmail'));
    console.log(formData.get('txtClaveAcceso'));

    $.ajax({
        method: 'POST',
        url: "frmIniciarSesion.aspx/GetUsuario",
        data: JSON.stringify(usuario),
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    }).done((info) =>
    {        
        let alertaError = document.querySelector("#alerta-error");        
        let alertaUsuario = document.querySelector("#alerta-usuario");        

        if (info.d == 'Usuario no encontrado') {
            console.log(info.d)
            alertaError.removeAttribute('hidden');
            alertaUsuario.setAttribute('hidden',true);
        }
        else
        {
            console.log(info.d)
            alertaUsuario.removeAttribute('hidden');
            alertaError.setAttribute('hidden', true);            
            setTimeout(() => {                
                window.location.href = 'frmInicio.aspx';
            }, 1800);
        }

    });

    /*fetch('frmIniciarSesion.aspx/GetUsuario', {
        method: 'POST',
        body: formData
        })
        .then((response) => response.text())
        .then((data) => {
            console.log(data)
            if (data == 'Administrador') {
                //alerta_error.classList = 'alert-success';
                setTimeout(() => {
                    alert('Administrador');
                    //location.href = 'administracion.php';
                }, 1000);
            }
            else if (data == 'Empleado')
            {
                alert('Empleado');
            }
            else if (data == 'Cliente')
            {
                alert('Cliente');
            }
            else
            {
                //alerta_error.hidden = false;
                setTimeout(() => {
                    //alerta_error.hidden = true;
                }, 5000);
            }
        })*/

})