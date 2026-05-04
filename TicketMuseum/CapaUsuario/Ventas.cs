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
using TicketMuseum.CapaConexion;
using Microsoft.Data.SqlClient;

namespace TicketMuseum
{
    public partial class Ventas : Form
    {


        public Ventas()
        {
            InitializeComponent();
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar el registro actual? Se borrarán los datos ingresados.",
        "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
          
                tbNombreResponsable.Clear(); 

               
                numBoletos.Value = 1;

           
                cbMetodoPago.SelectedIndex = -1;

            
                txttotal.Text = "50.00";

            
                tbNombreResponsable.Focus();

                MessageBox.Show("Registro cancelado.", "Sistema TicketMuseum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombreResponsable.Text) || tbNombreResponsable.Text == "Nombre Responsable")
            {
                MessageBox.Show("Por favor, ingrese el nombre del responsable.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numBoletos.Value == 0)
            {
                MessageBox.Show("La cantidad de boletos debe ser al menos 1.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un método de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

       
            try
            {
                using (SqlConnection cn = Conexion.Leer())
                {
                    cn.Open();

                  
                    string sqlVisitante = "INSERT INTO TB_VISITANTES (Nom_visita, Cant_bol) VALUES (@nom, @cant)";
                    SqlCommand cmd1 = new SqlCommand(sqlVisitante, cn);
                    cmd1.Parameters.AddWithValue("@nom", tbNombreResponsable.Text);
                    cmd1.Parameters.AddWithValue("@cant", (int)numBoletos.Value);
                    cmd1.ExecuteNonQuery();

                 
                    string sqlVenta = "INSERT INTO TB_VENTAS (Monto_total, Metodo_pago) VALUES (@monto, @metodo)";
                    SqlCommand cmd2 = new SqlCommand(sqlVenta, cn);

                    
                    decimal montoFinal = Convert.ToDecimal(txttotal.Text);
                    cmd2.Parameters.AddWithValue("@monto", montoFinal);
                    cmd2.Parameters.AddWithValue("@metodo", cbMetodoPago.Text);
                    cmd2.ExecuteNonQuery();

                
                    MessageBox.Show("Venta y Acceso registrados exitosamente.", "Sistema TicketMuseum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            tbNombreResponsable.Clear();
            numBoletos.Value = 1;
            cbMetodoPago.SelectedIndex = -1;
          
        }

        private void numBoletos_ValueChanged(object sender, EventArgs e)
        {
            decimal costoBoleto = 50.00m;

        
            int cantidad = (int)numBoletos.Value;

         
            decimal total = cantidad * costoBoleto;

           
            txttotal.Text = total.ToString("N2");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
