/*document.getElementById('button').addEventListener('click', function(event) {
    // Evitar que el formulario se envíe
    event.preventDefault();});*/

document.getElementById('button').addEventListener('click', function(event) {
    event.preventDefault(); // Evita que el formulario se envíe si es un botón de tipo submit
    window.location.href = "/Menu/Menu.html";
});

 // Obtener los valores de los campos del formulario
 const idCliente = document.getElementById('idcliente').value;
 const nombre = document.getElementById('nombre').value;
 const apellidoP = document.getElementById('apellidop').value;
 const apellidoM = document.getElementById('apellidom').value;
 const telefono = document.getElementById('telefono').value;
 const correo = document.getElementById('correo').value;
 const ciudad = document.getElementById('ciudad').value;
 const colonia = document.getElementById('colonia').value;
 const calle = document.getElementById('calle').value;
 const nCalle = document.getElementById('ncalle').value;
 const cp = document.getElementById('cp').value;
 const idContrato = document.getElementById('idcontrato').value;

 // Crear una nueva fila
 const table = document.getElementById('dataGridView').getElementsByTagName('tbody')[0];
 const newRow = table.insertRow();

 // Insertar las celdas en la fila
 newRow.insertCell(0).textContent = idCliente;
 newRow.insertCell(1).textContent = nombre;
 newRow.insertCell(2).textContent = apellidoP;
 newRow.insertCell(3).textContent = apellidoM;
 newRow.insertCell(4).textContent = telefono;
 newRow.insertCell(5).textContent = correo;
 newRow.insertCell(6).textContent = ciudad;
 newRow.insertCell(7).textContent = colonia;
 newRow.insertCell(8).textContent = calle;
 newRow.insertCell(9).textContent = nCalle;
 newRow.insertCell(10).textContent = cp;
 newRow.insertCell(11).textContent = idContrato;

 // Limpiar los campos del formulario
 document.getElementById('clienteForm').reset();

 document.getElementById('consultButton').addEventListener('click', function() {
    document.getElementById('tableContainer').style.display = 'block';
});

document.getElementById('backButton').addEventListener('click', function() {
    document.getElementById('tableContainer').style.display = 'none';
});