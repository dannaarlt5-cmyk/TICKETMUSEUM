using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TicketMuseum.CapaConexion;
namespace TicketMuseum
{
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            CargarDatosBitacora();
        }

        public void CargarDatosBitacora(string filtro = "")
        {
            try
            {
                using (SqlConnection con = Conexion.Leer())
                {
                    // Consulta base
                    string query = @"SELECT V.Nom_visita, VT.Metodo_pago, V.hora_ent 
                             FROM TB_VISITANTES V 
                             INNER JOIN TB_VENTAS VT ON V.Id_visita = VT.Id_venta 
                             WHERE CAST(V.hora_ent AS DATE) = CAST(@fecha AS DATE)";

                    // Si también hay texto en el buscador, añadimos la condición
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        query += " AND V.Nom_visita LIKE @filtro";
                    }

                    query += " ORDER BY V.hora_ent DESC";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Pasamos la fecha seleccionada en tu DateTimePicker (llamado dtpFecha aquí)
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);

                    if (!string.IsNullOrEmpty(filtro))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    }

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dgvBitacora.Rows.Clear();

                    while (reader.Read())
                    {
                        dgvBitacora.Rows.Add(
                            reader["Nom_visita"].ToString(),
                            reader["Metodo_pago"].ToString(),
                            Convert.ToDateTime(reader["hora_ent"]).ToString("dd/MM/yyyy HH:mm:ss")
                        );
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por fecha: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatosBitacora(txtBuscar.Text);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarDatosBitacora(txtBuscar.Text);
        }
    }
}
