using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Positions
    {
        /// <summary>
        /// Esta estructura almacena los cargos del usuario, escencial para
        /// realizar las condiciones de los permisos de usuario (Para el ejemplo del proyecto).
        /// De igual manera esto es opcional, en su lugar puedes usar
        /// una tabla de cargos en la base de datos, puedes hacerlo
        /// mediante enumeraciones y el ID de los cargos.
        /// </summary>

        public const string GeneralManager = "gerente general";
        public const string Accountant = "Contador";
        public const string MarketingGuru = "Marketing";
        public const string AdministrativeAssistant = "asistente administrativo";
        public const string HMR = "recursos humanos";
        public const string Receptionist = "recepcionista";
        public const string SystemAdministrator = "Administrador";

        public static IEnumerable<string> GetPositions()
        {//Método para listar los cargos. Se usa para establece la fuente de datos
            //del ComboBox en el formulario usuario de la capa de interfaz de usuario.
            var positions = new List<string>();
            positions.Add(GeneralManager);
            positions.Add(Accountant);
            positions.Add(MarketingGuru);
            positions.Add(AdministrativeAssistant);
            positions.Add(HMR);
            positions.Add(Receptionist);
            positions.Add(SystemAdministrator);
            positions.Sort();
            return positions;
        }
    }
}
