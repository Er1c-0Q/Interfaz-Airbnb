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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.editar
{
    public partial class editaravion : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-J0KTAMB\SQLEXPRESS;Initial Catalog=MyCompanyTest;Integrated Security=True");
        public editaravion()
        {
            InitializeComponent();
            CargarIdAvion();
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

        private void CargarIdAvion()
        {
            try
            {
                conexion.Open();
                string query = "SELECT idavion FROM Aviones";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["idavion"].ToString());
                }
                conexion.Close(); // Cierra la conexión después de usarla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar id del avion: " + ex.Message);
            }
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editaravion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modificar = "UPDATE Aviones SET regresob=@REGRESOB, tipoavion=@TIPOAVION" +
              " WHERE idavion=@IDAVION";

            SqlCommand comando = new SqlCommand(modificar, conexion);
            conexion.Open();
            try
            {
                comando.Parameters.AddWithValue("idavion", comboBox1.Text);
                comando.Parameters.AddWithValue("regresob", comboBox2.Text);
                comando.Parameters.AddWithValue("tipoavion", textBox3.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("MODIFICACION REALIZADA EXCITOSAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MODIFICACION NO REALIZADA");
            }
            conexion.Close();

            textBox3.Clear();
            comboBox2.Text = "";
            comboBox1.Text = "";
        }
    }
}
