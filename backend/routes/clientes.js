const express = require('express');
const router = express.Router();

// Consultar todos los clientes
router.get('/', async (req, res) => {
    try {
        const result = await req.pool.request().query('SELECT * FROM Clientes');
        res.json(result.recordset);
    } catch (err) {
        res.status(500).send(err.message);
    }
});

// Insertar un nuevo cliente
router.post('/', async (req, res) => {
    try {
        const { nombre, email, telefono } = req.body;
        const result = await req.pool.request()
            .input('Nombre', sql.VarChar, nombre)
            .input('Email', sql.VarChar, email)
            .input('Telefono', sql.VarChar, telefono)
            .query('INSERT INTO Clientes  VALUES ()');
        res.status(201).json({ message: 'Cliente insertado exitosamente' });
    } catch (err) {
        res.status(500).send(err.message);
    }
});

// Actualizar un cliente existente
router.put('/:id', async (req, res) => {
    try {
        const { id } = req.params;
        const { nombre, email, telefono } = req.body;
        const result = await req.pool.request()
            .input('Id', sql.Int, id)
            .input('Nombre', sql.VarChar, nombre)
            .input('Email', sql.VarChar, email)
            .input('Telefono', sql.VarChar, telefono)
            .query('UPDATE Clientes SET ');
        res.json({ message: 'Cliente actualizado exitosamente' });
    } catch (err) {
        res.status(500).send(err.message);
    }
});

// Eliminar un cliente
router.delete('/:id', async (req, res) => {
    try {
        const { id } = req.params;
        const result = await req.pool.request()
            .input('Id', sql.Int, id)
            .query('DELETE FROM Clientes WHERE ');
        res.json({ message: 'Cliente eliminado exitosamente' });
    } catch (err) {
        res.status(500).send(err.message);
    }
});

module.exports = router;