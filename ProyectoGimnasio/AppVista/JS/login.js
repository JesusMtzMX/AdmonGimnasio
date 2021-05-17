let formLogin = document.querySelector("#form");
let liActive = document.querySelector("#iniciar-sesion");
liActive.classList = "active-section";

formLogin.addEventListener('submit', (e) => {
    e.preventDefault();

    alert('Submit');

    let formData = new FormData(formLogin);

    /*console.log(formData.get('Email'));
    console.log(formData.get('Clave'));*/

    fetch('../AppControlador/UsuarioDAO.php', {
        method: 'POST',
        body: formData
    })
        .then(response => response.text())
        .then(data => {
            if (data == 'Administrador') {
                alerta_error.classList = 'alert-success';
                setTimeout(() => {
                    location.href = 'administracion.php';
                }, 1000);
            }
            else if (data == 'Empleado') {
                alert('Empleado');
            }
            else if (data == 'Cliente') {
                alert('Cliente');
            }
            else {
                alerta_error.hidden = false;
                setTimeout(() => {
                    alerta_error.hidden = true;
                }, 5000);
            }
        })

})