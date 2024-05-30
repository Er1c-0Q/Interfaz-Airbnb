/*const username = document.getElementById('username');
const password = document.getElementById('password');
const button = document.getElementById('button');

button.addEventListener('click', (e) => {
    e.preventDefault()
    const data = {
        username: username.value,
        password: password.value
    }

    console.log(data)
});*/

document.getElementById('login-button').addEventListener('click', function(event) {
    event.preventDefault(); // Evita que el formulario se envíe si es un botón de tipo submit
    window.location.href = "/Menu/Menu.html";
});

