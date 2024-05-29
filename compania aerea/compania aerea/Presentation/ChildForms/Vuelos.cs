using Presentation.capturas;
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
    public partial class Vuelos : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-J0KTAMB\SQLEXPRESS;Initial Catalog=MyCompanyTest;Integrated Security=True");
        public Vuelos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtSearch.Text == "")
            {
                string a = "Select * from VUELOS";
                SqlCommand comando = new SqlCommand(a, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }
            else
            {
                string a = "Select * from VUELOS where IDVUELO = '" + txtSearch.Text + "'";
                SqlCommand comando = new SqlCommand(a, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            agregarvuelo nuevoForm = new agregarvuelo();
            nuevoForm.StartPosition = FormStartPosition.CenterParent;
            nuevoForm.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editarvuelo nuevoForm = new editarvuelo();
            nuevoForm.StartPosition = FormStartPosition.CenterParent;
            nuevoForm.ShowDialog(this);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID de la ciudad seleccionada
                string idCiudad = dataGridView1.SelectedRows[0].Cells["IDVUELO"].Value.ToString();

                // Consulta SQL para eliminar la ciudad
                string baja = "DELETE FROM VUELOS WHERE idvuelo = @IDVUELO";

                try
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand(baja, conexion);
                    cmd.Parameters.Add("@IDVUELO", SqlDbType.VarChar).Value = idCiudad;
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    cmd = null;

                    conexion.Close();
                    MessageBox.Show("Vuelo Eliminado");

                    // Actualizar el DataGridView después de eliminar la fila
                    button1_Click(sender, e); // Llamar al método para recargar los datos en el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el vuelo: " + ex.Message);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

    }
}
