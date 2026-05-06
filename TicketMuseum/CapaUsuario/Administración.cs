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

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Está seguro que el efectivo coincide con " + lblEfectivo.Text + "?",
                                    "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                // 1. Llamamos a la función de imprimir (pasándole nulo en los parámetros si es un evento de botón)
                btnImprimir_Click(null, null);

                // 2. Mostramos el mensaje de éxito
                MessageBox.Show("Caja cerrada exitosamente. Reporte enviado a impresión.", "Éxito");

                // 3. Cerramos el formulario de cierre de caja
                this.Close();
            }
        }



        private void CalcularMontoTotal()
        {
            try
            {
                using (SqlConnection con = Conexion.Leer())
                {
                    // Consulta para traer los totales separados por método de pago
                    string query = @"
                SELECT 
                    ISNULL(SUM(CASE WHEN Metodo_pago = 'Efectivo' THEN Monto_total ELSE 0 END), 0) AS TotalEfectivo,
                    ISNULL(SUM(CASE WHEN Metodo_pago = 'Tarjeta' THEN Monto_total ELSE 0 END), 0) AS TotalTarjeta,
                    ISNULL(SUM(Monto_total), 0) AS TotalGeneral
                FROM TB_VENTAS 
                WHERE CAST(Fecha_venta AS DATE) = CAST(GETDATE() AS DATE)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Asignamos a tus Labels (asegúrate de que los nombres coincidan)
                        lblEfectivo.Text = Convert.ToDecimal(reader["TotalEfectivo"]).ToString("C2");
                        lblTarjeta.Text = Convert.ToDecimal(reader["TotalTarjeta"]).ToString("C2");
                        lblMontoTotal.Text = Convert.ToDecimal(reader["TotalGeneral"]).ToString("C2");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desglosar pagos: " + ex.Message);
            }
        }

        private void Administración_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm");

            CalcularMontoTotal();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo comprobante de cierre de caja...", "Impresión");
        }
    }
}
