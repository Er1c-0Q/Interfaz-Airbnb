using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ChildForms
{
    public partial class FormRecoverPassword : BaseForms.BaseFixedForm
    {
        /// <summary>
        /// Esta clase hereda de la clase BaseFixedForm.
        /// </summary>
        /// 
        public FormRecoverPassword()
        {
            InitializeComponent();
            lblMessage.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) == false)
            {
                
            }
            else
            {
                lblMessage.Text = "Por favor ingrese su nombre de usuario o email";
                lblMessage.ForeColor = Color.IndianRed;
            }
        }
    }
}
