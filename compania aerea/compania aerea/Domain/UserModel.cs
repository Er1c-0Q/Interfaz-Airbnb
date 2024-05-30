using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DBServices;
using DataAccess.DBServices.Entities;
using DataAccess.MailServices;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace Domain
{
    public class UserModel
    {
        #region -> Atributos

        private int _id;
        private string _usuario;
        private string _contrasenia;
        private string _nombres;
        private string _apellidoP;
        private string _apellidoM;
        private string _correo;
        private string _telefono;
        private int _cp;
        private string _calle;
        private int _numCalle;
        private string _colonia;
        private int _ciudadId;
        private UserDao _userDao;

        private ConnectionToSql conexion;
        #endregion

        #region -> Constructores

        public UserModel()
        {
            _userDao = new UserDao();
            conexion = new ConnectionToSql();
        }

        public UserModel(int id, string usuario, string contrasenia, string nombres, string apellidoP, string apellidoM, string correo, string telefono, int cp, string calle, int numCalle, string colonia, int ciudadId)
        {
            Id = id;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            Nombres = nombres;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Correo = correo;
            Telefono = telefono;
            Cp = cp;
            Calle = calle;
            NumCalle = numCalle;
            Colonia = colonia;
            CiudadId = ciudadId;

            _userDao = new UserDao();
        }

        #endregion

        #region -> Propiedades + Validacíon y Visualización de Datos

        //Posición 0 
        [DisplayName("Num")]//Nombre a visualizar (Por ejemplo en la columna del datagridview se mostrará como Num).
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //Posición 1 
        [DisplayName("Usuario")]//Nombre a visualizar.
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]//Validaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre de usuario debe contener un mínimo de 5 caracteres.")]
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        //Posición 2
        [DisplayName("Contraseña")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización (Por ejemplo no mostrar en el datagridview).
        [Required(ErrorMessage = "Por favor ingrese una contraseña.")]//Valicaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "La contraseña debe contener un mínimo de 5 caracteres.")]
        public string contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }

        //Posición 3
        [DisplayName("Nombres")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese nombre")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe contener un mínimo de 3 caracteres.")]
        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        //Posición 4
        [DisplayName("Apellido Paterno")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese apellido.")]//Validaciones
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El apellido debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El apellido debe contener un mínimo de 3 caracteres.")]
        public string ApellidoP
        {
            get { return _apellidoP; }
            set { _apellidoP = value; }
        }

        //Posición 9
        [DisplayName("Apellido Materno")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese apellido.")]//Validaciones
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El apellido debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El apellido debe contener un mínimo de 3 caracteres.")]
        public string ApellidoM
        {
            get { return _apellidoM; }
            set { _apellidoM = value; }
        }

        //Posición 5
        [ReadOnly(true)]//Solo lectura.
        [DisplayName("Nombre completo")]//Nombre a visualizar.
        public string FullName
        {
            get { return $"{ApellidoP} {ApellidoM} {Nombres}"; }
        }

        //Posición 11
        [DisplayName("Correo")]//Nombre a visualizar.
        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        //Posición 12
        [DisplayName("Teléfono")]//Nombre a visualizar.
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        //Posición 13
        [DisplayName("Código Postal")]//Nombre a visualizar.
        public int Cp
        {
            get { return _cp; }
            set { _cp = value; }
        }

        //Posición 14
        [DisplayName("Calle")]//Nombre a visualizar.
        public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        //Posición 15
        [DisplayName("Número de Calle")]//Nombre a visualizar.
        public int NumCalle
        {
            get { return _numCalle; }
            set { _numCalle = value; }
        }

        //Posición 16
        [DisplayName("Colonia")]//Nombre a visualizar.
        public string Colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }

        //Posición 17
        [DisplayName("Ciudad Id")]//Nombre a visualizar.
        public int CiudadId
        {
            get { return _ciudadId; }
            set { _ciudadId = value; }
        }

        #endregion

        #region -> Métodos Públicos

        public UserModel Login(string usuario, string contrasenia)
        {//Iniciar sesion.
            var result = _userDao.Login(usuario, contrasenia);
            if (result != null)
                return MapUserModel(result);
            else
                return null;
        }
        public bool ValidateActiveUser()
        {//Seguridad
            return _userDao.ValidateActiveUser();
        }

        public int CreateUser()
        {//Agregar nuevo usuario.
            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            User userEntity = MapUserEntity(this);
            return _userDao.CreateUser(userEntity);
        }
        public int ModifyUser()
        {//Actualizar usuario.

            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            User userEntity = MapUserEntity(this);
            return _userDao.ModifyUser(userEntity);
        }
        public int RemoveUser(int id)
        {//Eliminar usuario.

            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            return _userDao.RemoveUser(id);
        }
        public UserModel GetUserById(int id)
        {//Obtener usuario por ID.
            var result = _userDao.GetUserById(id);
            if (result != null)
                return MapUserModel(result);
            else
                return null;
        }
        public IEnumerable<UserModel> GetAllUsers()
        {
            List<UserModel> users = new List<UserModel>();

            using (var connection = conexion.GetConnection())//Obtener conexion
            {
                string query = "SELECT u.id_usuario, u.usuario, u.contrasenia, s.id_socio, s.apellido_p, s.apellido_m, s.nombres, s.correo, s.telefono, s.cp, s.calle, s.num_calle, s.colonia, s.id_ciudad " +
                               "FROM Usuarios u " +
                               "LEFT JOIN Socios s ON u.id_usuario = s.id_usuario " +
                               "UNION " +
                               "SELECT u.id_usuario, u.usuario, u.contrasenia, c.id_cliente, c.apellido_p, c.apellido_m, c.nombres, c.correo, c.telefono, c.cp, c.calle, c.num_calle, c.colonia, c.id_ciudad " +
                               "FROM Usuarios u " +
                               "LEFT JOIN Clientes c ON u.id_usuario = c.id_usuario";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UserData userData = new UserData
                    {
                        Id = (int)reader["id_usuario"],
                        usuario = (string)reader["usuario"],
                        contrasenia = (string)reader["contrasenia"],
                        ApellidoP = reader["apellido_p"] == DBNull.Value ? "" : (string)reader["apellido_p"],
                        ApellidoM = reader["apellido_m"] == DBNull.Value ? "" : (string)reader["apellido_m"],
                        Nombres = reader["nombres"] == DBNull.Value ? "" : (string)reader["nombres"],
                        Correo = reader["correo"] == DBNull.Value ? "" : (string)reader["correo"],
                        Telefono = reader["telefono"] == DBNull.Value ? "" : (string)reader["telefono"],
                        Cp = reader["cp"] == DBNull.Value ? 0 : (int)reader["cp"],
                        Calle = reader["calle"] == DBNull.Value ? "" : (string)reader["calle"],
                        NumCalle = reader["num_calle"] == DBNull.Value ? 0 : (int)reader["num_calle"],
                        Colonia = reader["colonia"] == DBNull.Value ? "" : (string)reader["colonia"],
                        CiudadId = reader["id_ciudad"] == DBNull.Value ? 0 : (int)reader["id_ciudad"]
                    };

                    UserModel userModel = MapUserDataToUserModel(userData);
                    users.Add(userModel);
                }
            }

            return users;
        }
        #endregion

        #region -> Métodos Privados (Mapear datos)

        //Mapear modelo de dominio a modelo de entidad.
        private UserModel MapUserDataToUserModel(UserData userData)
        {
            UserModel userModel = new UserModel
            {
                Id = userData.Id,
                usuario = userData.usuario,
                contrasenia = userData.contrasenia,
                ApellidoP = userData.ApellidoP,
                ApellidoM = userData.ApellidoM,
                Nombres = userData.Nombres,
                Correo = userData.Correo,
                Telefono = userData.Telefono,
                Cp = userData.Cp,
                Calle = userData.Calle,
                NumCalle = userData.NumCalle,
                Colonia = userData.Colonia,
                CiudadId = userData.CiudadId
            };

            return userModel;
        }
        private User MapUserEntity(UserModel userModel)
        {
            var userEntity = new User
            {
                Id = userModel.Id,
                Username = userModel.usuario,
                Password = userModel.contrasenia,
            };
            return userEntity;
        }

        //Mapear modelo entidad a modelo de dominio.
        private UserModel MapUserModel(User userEntity)
        {//Mapear un solo objeto.
            var userModel = new UserModel()
            {
                Id = userEntity.Id,
                usuario = userEntity.Username,
                contrasenia = userEntity.Password,
            };
            return userModel;
        }
        private IEnumerable<UserModel> MapUserModel(IEnumerable<User> userEntities)
        {//Mapear colección de objetos.
            var userModels = new List<UserModel>();
            foreach (var user in userEntities)
            {
                userModels.Add(MapUserModel(user));
            }
            return userModels;
        }

        #endregion

    }

    public class UserData
    {
        public int Id { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int Cp { get; set; }
        public string Calle { get; set; }
        public int NumCalle { get; set; }
        public string Colonia { get; set; }
        public int CiudadId { get; set; }
    }

}
