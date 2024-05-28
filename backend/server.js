// server.js
const express = require('express');
const sql = require('mssql');
const backendconnection = require('./dbconfig');
const { default: next } = require('next');
const connectDB = require('./dbconfig');
const bodyParser = require('body-parser');

const clientsRoutes = require('./routes/clientes');

const app = express();
const port = 3000;

//conexión con la base
app.use(async (req, res, next) => 
    {
        try
        {
            if (req.pool)
                {
                    req.pool = await connectDB();
                }
                next();
        }
        catch (r)
        {
            next(r);
        }
    }
);

app.use(bodyParser.json());

app.use('/clientes', clientsRoutes);

app.listen(port, () =>
{
    console.log('Servidor corriendo');
});
