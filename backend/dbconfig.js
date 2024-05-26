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

module.exports = config;