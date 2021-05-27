let formLogin = document.querySelector(".form");
let liActive = document.querySelector("#iniciar-sesion");
let btnCrearCuenta = document.querySelector("#btnCrearCuenta");

liActive.classList = "active-section";

gotoCrearCuenta = () => {
    location.href = 'frmRegistroCliente.aspx';
}

formLogin.addEventListener('submit', (e) => {
    e.preventDefault();

    alert('Submit');

    let formData = new FormData(formLogin);

    console.log(formData.get('txtEmail'));
    console.log(formData.get('txtClave'));

    fetch('../AppControlador/UsuarioDAO.cs', {
        method: 'POST',
        body: formData
    })
        .then(response => response.text())
        .then(data => {
            if (data == 'Administrador') {
                alerta_error.classList = 'alert-success';
                setTimeout(() => {
                    alert('Administrador');
                    //location.href = 'administracion.php';
                }, 1000);
            }
            else if (data == 'Empleado') {
                alert('Empleado');
            }
            else if (data == 'Cliente') {
                alert('Cliente');
            }
            else {
                //alerta_error.hidden = false;
                setTimeout(() => {
                    //alerta_error.hidden = true;
                }, 5000);
            }
        })

})