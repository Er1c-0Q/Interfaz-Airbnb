using Presentation.editar;
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

namespace Presentation.ChildForms
{
    public partial class FormPacients : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-J0KTAMB\SQLEXPRESS;Initial Catalog=MyCompanyTest;Integrated Security=True");
        public FormPacients()
        {
            InitializeComponent();
        }

        private void FormPacients_Load(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            agregapiloto nuevoForm = new agregapiloto();
            nuevoForm.StartPosition = FormStartPosition.CenterParent;
            nuevoForm.ShowDialog(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {



            if (txtSearch.Text == "")
            {
                string query = "SELECT IDPILOTO AS 'ID del Piloto', nombre AS 'Nombre del Piloto', horasvuelo AS 'Horas de Vuelo', regresob AS 'Regreso' FROM Pilotos";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }
            else
            {
                string query = "SELECT IDPILOTO AS 'ID del Piloto', nombre AS 'Nombre del Piloto', horasvuelo AS 'Horas de Vuelo', regresob AS 'Regreso' FROM Pilotos WHERE IDPILOTO = '" + txtSearch.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID de la ciudad seleccionada
                string idCiudad = dataGridView1.SelectedRows[0].Cells["IDPILOTO"].Value.ToString();

                // Consulta SQL para eliminar la ciudad
                string baja = "DELETE FROM PILOTOS WHERE idpiloto = @IDPILOTO";

                try
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand(baja, conexion);
                    cmd.Parameters.Add("@IDPILOTO", SqlDbType.VarChar).Value = idCiudad;
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    cmd = null;

                    conexion.Close();
                    MessageBox.Show("Piloto Eliminado");

                    // Actualizar el DataGridView después de eliminar la fila
                    btnSearch_Click(sender, e); // Llamar al método para recargar los datos en el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el piloto: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editarpiloto nuevoForm = new editarpiloto();
            nuevoForm.StartPosition = FormStartPosition.CenterParent;
            nuevoForm.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (txtSearch.Text == "")
            {
                string query = "SELECT IDPILOTO AS 'ID del Piloto', nombre AS 'Nombre del Piloto', horasvuelo AS 'Horas de Vuelo', regresob AS 'Regreso' FROM Pilotos";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }
            else
            {
                string query = "SELECT IDPILOTO AS 'ID del Piloto', nombre AS 'Nombre del Piloto', horasvuelo AS 'Horas de Vuelo', regresob AS 'Regreso' FROM Pilotos WHERE IDPILOTO = '" + txtSearch.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }
        }
    }
}
