using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBServices
{
    public class ConnectionToSql
    {
        /// <summary>
        /// Esta clase abstracta es responsable de establecer la cadena de conexion
        /// y obtener la conexion a SQL.
        /// </summary>
        /// 

        private readonly string connectionString;//Obtiene o establece la cadena de conexión.

        public ConnectionToSql()
        {
            //Establecer la cadena de conexión.
            // connectionString = "Server=(local); DataBase= MyCompanyTest; Integrated Security= true";
            //connectionString = "Server=.\\LOCALHOST; Database=PROYECTO_FINAL_DB; Integrated Security=true";
            connectionString = "Server=.\\SQLEXPRESS; Database=PROYECTO_FINAL_DB; Integrated Security=true";
        }
        public SqlConnection GetConnection()
        {
            //Este métedo se encarga de establecer y devolver el objeto de conexión a SQL Server.
            return new SqlConnection(connectionString);
        }
    }
}
