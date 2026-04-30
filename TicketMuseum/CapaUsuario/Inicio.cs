using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TicketMuseum.CapaUsuario;

namespace TicketMuseum
{
    public partial class Inicio : Form
    {
        [DllImport("user32.dll")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public Inicio()
        {
            InitializeComponent();
            pMenu.Width = 75;
            btVentas.Text = "";
            btAdministracion.Text = "";
            btBitacora.Text = "";
            btCerrarSesión.Text = "";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (pMenu.Width == 250)
            {
                pMenu.Width = 75;
                btVentas.Text = "";
                btAdministracion.Text = "";
                btBitacora.Text = "";
                btCerrarSesión.Text = "";
            }
            else if (pMenu.Width == 75)
            {
                pMenu.Width = 250;
                btVentas.Text = "Ventas";
                btAdministracion.Text = "Administración";
                btBitacora.Text = "Bitácora";
                btCerrarSesión.Text = "Cerrar Sesión";
            }
        }

        private void btVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.FormClosed += (s, args) => this.Show();
            ventas.Show();
            this.Hide();
        }

        private void btBitacora_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora();
            bitacora.FormClosed += (s, args) => this.Show();
            bitacora.Show();
            this.Hide();
        }

        private void btCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btAdministracion_Click(object sender, EventArgs e)
        {
            Administración administración = new Administración();
            
            administración.FormClosed += (s, args) => this.Show();
            administración.Show();
            this.Hide();
        }
    }
}
