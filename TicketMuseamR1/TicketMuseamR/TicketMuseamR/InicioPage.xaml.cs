using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;

namespace TicketMuseamR
{
    /// <summary>
    /// Lógica de interacción para InicioPage.xaml
    /// </summary>
    public partial class InicioPage : Page
    {
        private string conexionString = @"Server=(local)\SQLEXPRESS;Database=BDMUSEO;Integrated Security=True; TrustServerCertificate=True";
        public InicioPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CalcularMetricasDeHoy();
        }

        private void CalcularMetricasDeHoy()
        {
            // Definir el rango exacto para el día de hoy (de 00:00:00 a 23:59:59)
            DateTime inicioHoy = DateTime.Today;
            DateTime finHoy = DateTime.Today.AddDays(1).AddSeconds(-1);

            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();

                    // 1. CONSULTA PARA LAS VENTAS DE HOY (Suma de montos en TB_VENTAS)
                    string queryVentas = "SELECT ISNULL(SUM(Monto_total), 0) FROM TB_VENTAS WHERE Fecha_venta >= @In AND Fecha_venta <= @Fi";
                    using (SqlCommand cmdVentas = new SqlCommand(queryVentas, conexion))
                    {
                        cmdVentas.Parameters.AddWithValue("@In", inicioHoy);
                        cmdVentas.Parameters.AddWithValue("@Fi", finHoy);

                        decimal ventasHoy = Convert.ToDecimal(cmdVentas.ExecuteScalar());

                        // Modifica el texto en pantalla con formato de moneda
                        lblVentasHoy.Text = $"$ {ventasHoy:N2}";
                    }

                    // 2. CONSULTA PARA LOS VISITANTES DE HOY (Suma de boletos en TB_VISITANTES)
                    string queryVisitantes = "SELECT ISNULL(SUM(Cant_bol), 0) FROM TB_VISITANTES WHERE hora_ent >= @In AND hora_ent <= @Fi";
                    using (SqlCommand cmdVisitantes = new SqlCommand(queryVisitantes, conexion))
                    {
                        cmdVisitantes.Parameters.AddWithValue("@In", inicioHoy);
                        cmdVisitantes.Parameters.AddWithValue("@Fi", finHoy);

                        int visitantesHoy = Convert.ToInt32(cmdVisitantes.ExecuteScalar());

                        // Modifica el contador en pantalla
                        lblVisitantesHoy.Text = visitantesHoy.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos para cargar las métricas de hoy: " + ex.Message,
                                "Error de Datos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
