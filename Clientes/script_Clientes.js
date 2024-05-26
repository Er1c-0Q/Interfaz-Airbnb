document.getElementById('button').addEventListener('click', function(event) {
    event.preventDefault(); // Evita que el formulario se envíe si es un botón de tipo submit
    window.location.href = "/Menu/Menu.html";
});