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

namespace Presentation.capturas
{
    public partial class agregaravion : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-J0KTAMB\SQLEXPRESS;Initial Catalog=MyCompanyTest;Integrated Security=True");
        public agregaravion()
        {
            InitializeComponent();
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
                    comboBox1.Items.Add(reader["regresob"].ToString());
                }
                conexion.Close(); // Cierra la conexión después de usarla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el regreso a base de piloto: " + ex.Message);
            }
        }


        private void agregaravion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand altas = new SqlCommand("insert into Aviones (idavion,regresob,tipoavion) values(@IDAVION,@REGRESOB,@TIPOAVION)", conexion);

            // se pasan los valores de los text box a las variables temporales
            altas.Parameters.AddWithValue("idavion", textBox2.Text);
            altas.Parameters.AddWithValue("regresob", comboBox1.Text);
            altas.Parameters.AddWithValue("tipoavion", textBox3.Text);
            conexion.Open();// se abre la conexion
            altas.ExecuteNonQuery();
            conexion.Close();// se cierra la conexion
            MessageBox.Show("Avion Agregado");
            // limpiar los textbox
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
