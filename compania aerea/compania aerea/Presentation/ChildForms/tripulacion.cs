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

namespace Presentation.ChildForms
{
    public partial class tripulacion : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-J0KTAMB\SQLEXPRESS;Initial Catalog=MyCompanyTest;Integrated Security=True");
        public tripulacion()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {



            if (txtSearch.Text == "")
            {
                string query = "SELECT IDMIEMBRO AS 'ID tripulante', nombre AS 'Nombre del tripulante', regresob AS 'Regreso a base' FROM Tripulaciones";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }
            else
            {
                string query = "SELECT IDMIEMBRO AS 'ID tripulante', nombre AS 'Nombre del tripulante', regresob AS 'Regreso a base' FROM Tripulaciones WHERE IDMIEMBRO = '" + txtSearch.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            agregartripul nuevoForm = new agregartripul();
            nuevoForm.StartPosition = FormStartPosition.CenterParent;
            nuevoForm.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editartripul nuevoForm = new editartripul();
            nuevoForm.StartPosition = FormStartPosition.CenterParent;
            nuevoForm.ShowDialog(this);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID de la ciudad seleccionada
                string idCiudad = dataGridView1.SelectedRows[0].Cells["ID tripulante"].Value.ToString();

                // Consulta SQL para eliminar la ciudad
                string baja = "DELETE FROM TRIPULACIONES WHERE idmiembro = @IDMIEMBRO";

                try
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand(baja, conexion);
                    cmd.Parameters.Add("@IDMIEMBRO", SqlDbType.VarChar).Value = idCiudad;
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    cmd = null;

                    conexion.Close();
                    MessageBox.Show("Miembro Eliminado");

                    // Actualizar el DataGridView después de eliminar la fila
                    button1_Click(sender, e); // Llamar al método para recargar los datos en el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar miembro de tripulacion: " + ex.Message);
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
    }
}
