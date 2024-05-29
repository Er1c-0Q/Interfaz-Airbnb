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

namespace Presentation.capturas
{
    public partial class agregarvuelo : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-J0KTAMB\SQLEXPRESS;Initial Catalog=MyCompanyTest;Integrated Security=True");
        public agregarvuelo()
        {
            InitializeComponent();
            CargarIdPiloto();
            CargarIdAvion();
            CargarIdmiembro();
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
                    comboBox3.Items.Add(reader["Idmiembro"].ToString());
                }
                conexion.Close(); // Cierra la conexión después de usarla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ID miembros de tripulacion: " + ex.Message);
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
                    comboBox2.Items.Add(reader["idavion"].ToString());
                }
                conexion.Close(); // Cierra la conexión después de usarla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar id del avion: " + ex.Message);
            }
        }

        private void CargarIdPiloto()
        {
            try
            {
                conexion.Open();
                string query = "SELECT IdPiloto FROM Pilotos";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["IdPiloto"].ToString());
                }
                conexion.Close(); // Cierra la conexión después de usarla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ID de piloto: " + ex.Message);
            }
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarvuelo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand altas = new SqlCommand("insert into Vuelos (idvuelo,origen,destino,horavuelo,idpiloto,idavion,idmiembro) values(@IDVUELO,@ORIGEN,@DESTINO,@HORAVUELO,@IDPILOTO,@IDAVION,@IDMIEMBRO)", conexion);

            // se pasan los valores de los text box a las variables temporales
            altas.Parameters.AddWithValue("idvuelo", textBox1.Text);
            altas.Parameters.AddWithValue("origen", textBox2.Text);
            altas.Parameters.AddWithValue("destino", textBox3.Text);
            altas.Parameters.AddWithValue("horavuelo", textBox4.Text);
            altas.Parameters.AddWithValue("idpiloto", comboBox1.Text);
            altas.Parameters.AddWithValue("idavion", comboBox2.Text);
            altas.Parameters.AddWithValue("idmiembro", comboBox3.Text);
            conexion.Open();// se abre la conexion
            altas.ExecuteNonQuery();
            conexion.Close();// se cierra la conexion
            MessageBox.Show("Tripulante agregado");
            // limpiar los textbox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }
    }
}
