document.getElementById('Registrarse').addEventListener('click', function(event) {
    event.preventDefault(); // Evita que el formulario se envíe si es un botón de tipo submit
    window.location.href = "/Clientes/Clientes.html";
});

document.getElementById('Iniciar').addEventListener('click', function(event) {
    event.preventDefault(); // Evita que el formulario se envíe si es un botón de tipo submit
    window.location.href = "/Login/Login.html";
});

