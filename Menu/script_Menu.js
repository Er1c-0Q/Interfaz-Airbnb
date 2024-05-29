document.getElementById('Iniciar').addEventListener('click', function(event) {
    // Evitar que el formulario se envíe
    event.preventDefault();});

document.getElementById('Registrarse').addEventListener('click', function(event) {
    event.preventDefault(); // Evita que el formulario se envíe si es un botón de tipo submit
    window.location.href = "/Clientes/Clientes.html";
});


document.addEventListener('DOMContentLoaded', function() {
    // Obtener el botón de "Iniciar Sesión"
    const iniciarSesionBtn = document.getElementById('Iniciar');

    // Obtener los menús
    const menuDefault = document.querySelector('.menu-default');
    const menuLogin = document.querySelector('.menu-login');

    // Agregar el evento click al botón "Iniciar Sesión"
    iniciarSesionBtn.addEventListener('click', function(event) {
        event.preventDefault(); // Evita la acción predeterminada del botón

        // Ocultar el menú por defecto y mostrar el menú de login
        menuDefault.style.display = 'none';
        menuLogin.style.display = 'block';

        document.getElementById('Iniciar').addEventListener('click', function(event) {
            /*event.preventDefault(); // Evita que el formulario se envíe si es un botón de tipo submit*/
            window.location.href = "/Login/Login.html";
        });
        
    });
});

document.addEventListener('DOMContentLoaded', function() {
    // Obtener el botón de "Iniciar Sesión"
    const CerrarSesionBtn = document.getElementById('Cerrar');

    // Obtener los menús
    const menuDefault = document.querySelector('.menu-default');
    const menuLogin = document.querySelector('.menu-login');

    // Agregar el evento click al botón "Iniciar Sesión"
    iniciarSesionBtn.addEventListener('click', function(event) {
        event.preventDefault(); // Evita la acción predeterminada del botón

        // Ocultar el menú por defecto y mostrar el menú de login
        menuDefault.style.display = 'block';
        menuLogin.style.display = 'none';

        document.getElementById('Iniciar').addEventListener('click', function(event) {
            /*event.preventDefault(); // Evita que el formulario se envíe si es un botón de tipo submit*/
            window.location.href = "/Login/Login.html";
        });
        
    });
});


