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

namespace Presentation
{
    public partial class agregapiloto : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-J0KTAMB\SQLEXPRESS;Initial Catalog=MyCompanyTest;Integrated Security=True");
        public agregapiloto()
        {
            InitializeComponent();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand altas = new SqlCommand("insert into Pilotos (idpiloto,nombre,horasvuelo,regresob) values(@IDPILOTO,@NOMBRE,@HORASVUELO,@REGRESOB)", conexion);

            // se pasan los valores de los text box a las variables temporales
            altas.Parameters.AddWithValue("idpiloto", textBox1.Text);
            altas.Parameters.AddWithValue("nombre", textBox2.Text);
            altas.Parameters.AddWithValue("horasvuelo", textBox3.Text);
            altas.Parameters.AddWithValue("regresob", textBox4.Text);
            conexion.Open();// se abre la conexion
            altas.ExecuteNonQuery();
            conexion.Close();// se cierra la conexion
            MessageBox.Show("Piloto Agregado");
            // limpiar los textbox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void agregapiloto_Load(object sender, EventArgs e)
        {

        }
    }
}
