using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm(string username)
        {
            InitializeComponent();
            lblUsername.Text = username;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            timer1.Interval = 10; // Ajustar el intervalo del temporizador a 76 milisegundos
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 1.0 / (1 * 10); // Ajustar la velocidad de la animación
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {

                timer2.Stop();
                this.Close();
            }
        }

        private void WelcomeForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray), 0, 0, this.Width - 1, this.Height - 1);
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = @".\imagenes\avion.mp4"; // Cambia la ruta según la ubicación de tu archivo de video
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // El video ha terminado de reproducirse, ejecutar la siguiente ventana
                MainForm siguienteVentana = new MainForm();
                siguienteVentana.Show();

                // Cerrar esta ventana
                this.Close();
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
