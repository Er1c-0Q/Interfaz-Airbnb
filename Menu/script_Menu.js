document.getElementById('button').addEventListener('click', function(event) {
    event.preventDefault(); // Evita que el formulario se envíe si es un botón de tipo submit
    window.location.href = "/Clientes/Clientes.html";
});

document.getElementById('button2').addEventListener('click', function(event) {
    event.preventDefault(); // Evita que el formulario se envíe si es un botón de tipo submit
    window.location.href = "/Login/Login.html";
});