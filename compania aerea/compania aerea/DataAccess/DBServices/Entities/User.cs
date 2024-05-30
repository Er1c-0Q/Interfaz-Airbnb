using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBServices.Entities
{
   public class User
   {//Las entidades tienen los mismos campos de la tabla de la base de datos,
       //además esto te permite  cambiar facilmente a Entity Framework.

       public int Id { get; set; }
       public string Username { get; set; }
       public string Password { get; set; }
    }
}
