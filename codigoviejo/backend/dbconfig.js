//config database
const sql = require('mssql');

const config = {
    server: '.\\LOCALHOST', //mimaquina
    //server: '.\\SQLEXPRESS', //maquinagenerica
    database: 'nombre_database', 
    options: {
        encrypt: false,
        enableArithAbort: true,
        trustedConnection: true
    }
};

async function connectDB()
{
    try
    {
        const pool = await sql.connect(config);
        console.log("conectado a db");
        return pool;
    }
    catch (r)
    {
        console.error("error en la conexión con la base de datos", r);
        throw r;
    }
}

module.exports = connectDB;