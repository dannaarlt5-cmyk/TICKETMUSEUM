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
using TicketMuseum.CapaConexion;
using Microsoft.Data.SqlClient;

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

            Ventas formularioAbierto = Application.OpenForms.OfType<Ventas>().FirstOrDefault();

            if (formularioAbierto != null)
            {

                formularioAbierto.WindowState = FormWindowState.Normal;
                formularioAbierto.BringToFront();
                formularioAbierto.Focus();
            }
            else
            {
                pVentas.Visible = false;
                pVisitantes.Visible = false;
                lblBien.Visible = false;
                Ventas ventas = new Ventas();
                ventas.MdiParent = this;
                ventas.FormClosed += (s, args) =>
                {
                    pVentas.Visible = true;
                    pVisitantes.Visible = true;
                    lblBien.Visible = true;
                };


                 this.Show();

                ventas.Show();
            }

        }

        private void btBitacora_Click(object sender, EventArgs e)
        {

            Bitacora formAbierto = Application.OpenForms.OfType<Bitacora>().FirstOrDefault();

            if (formAbierto != null)
            {
                formAbierto.WindowState = FormWindowState.Normal;
                formAbierto.BringToFront();
                formAbierto.Focus();
            }
            else
            {
                pVentas.Visible = false;
                pVisitantes.Visible = false;
                lblBien.Visible = false;
                Bitacora bitacora = new Bitacora();
                bitacora.MdiParent = this;
                bitacora.FormClosed += (s, args) =>
                {
                    pVentas.Visible = true;
                    pVisitantes.Visible = true;
                    lblBien.Visible = true;
                };
                this.Show();
                bitacora.Show();
            }

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

            Administración formAbierto = Application.OpenForms.OfType<Administración>().FirstOrDefault();



            if (formAbierto != null)
            {
                formAbierto.WindowState = FormWindowState.Normal;
                formAbierto.BringToFront();
                formAbierto.Focus();
            }
            else
            {
                pVentas.Visible = false;
                pVisitantes.Visible = false;
                lblBien.Visible = false;
                Administración admin = new Administración();
                admin.MdiParent = this;
                admin.FormClosed += (s, args) =>
                {
                    pVentas.Visible = true;
                    pVisitantes.Visible = true;
                    lblBien.Visible = true;
                }; this.Show();
                admin.Show();
            }

        }

        //public void ActualizarDashboard()
        //{
        //    try
        //    {
        //        using (SqlConnection con = Conexion.Leer()) // Usando tu clase Conexion
        //        {
        //            con.Open();

        //            // 1. Consultar total de ventas de hoy
        //            string qVentas = "SELECT ISNULL(SUM(Monto_total), 0) FROM TB_VENTAS WHERE CAST(Fecha_venta AS DATE) = CAST(GETDATE() AS DATE)";
        //            SqlCommand cmdVentas = new SqlCommand(qVentas, con);
        //            lblTotalVentas.Text = "$" + cmdVentas.ExecuteScalar().ToString();

        //            // 2. Consultar visitantes de hoy
        //            string qVisitas = "SELECT ISNULL(SUM(Cant_bol), 0) FROM TB_VISITANTES WHERE CAST(hora_ent AS DATE) = CAST(GETDATE() AS DATE)";
        //            SqlCommand cmdVisitas = new SqlCommand(qVisitas, con);
        //            lblTotalVisitantes.Text = cmdVisitas.ExecuteScalar().ToString();



        //            con.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // En caso de error, dejamos los contadores en 0
        //    }
        //}

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            // Iniciamos la carga en segundo plano
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Inicio_Shown(object sender, EventArgs e)
        {
            //ActualizarDashboard();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (SqlConnection con = Conexion.Leer())
                {
                    con.Open();

                    // 1. Consultar Ventas de hoy
                    string qVentas = "SELECT ISNULL(SUM(Monto_total), 0) FROM TB_VENTAS WHERE CAST(Fecha_venta AS DATE) = CAST(GETDATE() AS DATE)";
                    SqlCommand cmdVentas = new SqlCommand(qVentas, con);
                    decimal ventas = Convert.ToDecimal(cmdVentas.ExecuteScalar());

                    // 2. Consultar Visitantes de hoy
                    string qVisitas = "SELECT ISNULL(SUM(Cant_bol), 0) FROM TB_VISITANTES WHERE CAST(hora_ent AS DATE) = CAST(GETDATE() AS DATE)";
                    SqlCommand cmdVisitas = new SqlCommand(qVisitas, con);
                    int visitas = Convert.ToInt32(cmdVisitas.ExecuteScalar());

                    // 3. Calculamos disponibles (Meta de 100)
                    int disponibles = 100 - visitas;

                    // Guardamos los 3 resultados en un arreglo para mandarlos al siguiente método
                    e.Result = new string[] { ventas.ToString("C2"), visitas.ToString(), disponibles.ToString() };

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                // Si hay error, mandamos valores en cero
                e.Result = new string[] { "$0.00", "0", "100" };
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] resultados = (string[])e.Result;

            // Actualizamos los Labels de tu Dashboard
            lblTotalVentas.Text = resultados[0];        // Ventas
            lblTotalVisitantes.Text = resultados[1];   // Visitantes
           

            // Opcional: Quitar un cursor de "espera" si lo pusiste
            this.Cursor = Cursors.Default;
        }
    }
}
