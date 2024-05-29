using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.editar
{
    public partial class editartripul : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-J0KTAMB\SQLEXPRESS;Initial Catalog=MyCompanyTest;Integrated Security=True");
        public editartripul()
        {
            InitializeComponent();
            CargarIdmiembro();
            CargarBase();
        }

        private void CargarBase()
        {
            try
            {
                conexion.Open();
                string query = "SELECT regresob FROM Pilotos";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["regresob"].ToString());
                }
                conexion.Close(); // Cierra la conexión después de usarla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el regreso a base de piloto: " + ex.Message);
            }
        }


        private void CargarIdmiembro()
        {
            try
            {
                conexion.Open();
                string query = "SELECT Idmiembro FROM Tripulaciones";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Idmiembro"].ToString());
                }
                conexion.Close(); // Cierra la conexión después de usarla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ID miembros de tripulacion: " + ex.Message);
            }

        }
            private void editartripul_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modificar = "UPDATE Tripulaciones SET nombre=@NOMBRE, regresob=@REGRESOB" +
              " WHERE idmiembro=@IDMIEMBRO";

            SqlCommand comando = new SqlCommand(modificar, conexion);
            conexion.Open();
            try
            {
                comando.Parameters.AddWithValue("idmiembro", comboBox1.Text);
                comando.Parameters.AddWithValue("nombre", textBox2.Text);
                comando.Parameters.AddWithValue("regresob", comboBox2.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("MODIFICACION REALIZADA EXCITOSAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MODIFICACION NO REALIZADA");
            }
            conexion.Close();
            textBox2.Clear();
            comboBox2.Text = "";
            comboBox1.Text = "";
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
