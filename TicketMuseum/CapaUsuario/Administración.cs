using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketMuseum.CapaConexion;
using Microsoft.Data.SqlClient;


namespace TicketMuseum.CapaUsuario
{
    public partial class Administración : Form
    {
        public Administración()
        {
            InitializeComponent();
        }
        private void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void IniciarHora()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;

            timer.Tick += (s, e) =>
            {
                lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            };

            timer.Start();
        }

        private void MostrarTotalRecaudado()
        {
            using (SqlConnection cn = Conexion.Leer())
            {
                cn.Open();

                string query = "SELECT ISNULL(SUM(Monto_total),0) FROM TB_VENTAS";

                SqlCommand cmd = new SqlCommand(query, cn);

                decimal total = Convert.ToDecimal(cmd.ExecuteScalar());

                lblTotalRecaudado.Text = "$ " + total.ToString("0.00");
            }
        }
        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Administración_Load(object sender, EventArgs e)
        {
            MostrarFecha();
            IniciarHora();
            MostrarTotalRecaudado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReporteVentas frm = new ReporteVentas();
            //frm.ShowDialog();
        }
        private decimal ObtenerTotal()
        {
            using (SqlConnection cn = Conexion.Leer())
            {
                cn.Open();

                string query = "SELECT ISNULL(SUM(Monto_total),0) FROM TB_VENTAS";

                SqlCommand cmd = new SqlCommand(query, cn);

                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "¿Deseas cerrar la caja?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                decimal totalCaja = ObtenerTotal();

                MessageBox.Show(
                    "Caja cerrada correctamente\nTotal recaudado: $ " + totalCaja.ToString("0.00"),
                    "Caja cerrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }
    }

}
