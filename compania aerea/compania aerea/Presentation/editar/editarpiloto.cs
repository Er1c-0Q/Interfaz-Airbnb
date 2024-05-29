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
    public partial class editarpiloto : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-J0KTAMB\SQLEXPRESS;Initial Catalog=MyCompanyTest;Integrated Security=True");
        public editarpiloto()
        {
            InitializeComponent();
            CargarIdPiloto();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Close();


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


        private void button1_Click(object sender, EventArgs e)
        {
            string modificar = "UPDATE Pilotos SET nombre=@NOMBRE, horasvuelo=@HORASVUELO, regresob=@REGRESOB" +
               " WHERE idpiloto=@IDPILOTO";

            SqlCommand comando = new SqlCommand(modificar, conexion);
            conexion.Open();
            try
            {
                comando.Parameters.AddWithValue("idpiloto", comboBox1.Text);
                comando.Parameters.AddWithValue("nombre", textBox2.Text);
                comando.Parameters.AddWithValue("horasvuelo", textBox3.Text);
                comando.Parameters.AddWithValue("regresob", textBox4.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("MODIFICACION REALIZADA EXCITOSAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MODIFICACION NO REALIZADA");
            }
            conexion.Close();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
        }

        private void editarpiloto_Load(object sender, EventArgs e)
        {

        }
    }
}
