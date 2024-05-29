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
    public partial class agregartripul : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-J0KTAMB\SQLEXPRESS;Initial Catalog=MyCompanyTest;Integrated Security=True");
        public agregartripul()
        {
            InitializeComponent();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand altas = new SqlCommand("insert into Tripulaciones (idmiembro,nombre,regresob) values(@IDMIEMBRO,@NOMBRE,@REGRESOB)", conexion);

            // se pasan los valores de los text box a las variables temporales
            altas.Parameters.AddWithValue("idmiembro", textBox1.Text);
            altas.Parameters.AddWithValue("nombre", textBox2.Text);
            altas.Parameters.AddWithValue("regresob", textBox4.Text);
            conexion.Open();// se abre la conexion
            altas.ExecuteNonQuery();
            conexion.Close();// se cierra la conexion
            MessageBox.Show("Tripulante agregado");
            // limpiar los textbox
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }
    }
}
