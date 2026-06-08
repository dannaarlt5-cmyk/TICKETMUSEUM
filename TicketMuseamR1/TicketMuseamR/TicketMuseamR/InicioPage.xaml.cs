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
           
            DateTime inicioHoy = DateTime.Today;
            DateTime finHoy = DateTime.Today.AddDays(1).AddSeconds(-1);

            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();

                   
                    string queryVentas = "SELECT ISNULL(SUM(Monto_total), 0) FROM TB_VENTAS WHERE Fecha_venta >= @In AND Fecha_venta <= @Fi";
                    using (SqlCommand cmdVentas = new SqlCommand(queryVentas, conexion))
                    {
                        cmdVentas.Parameters.AddWithValue("@In", inicioHoy);
                        cmdVentas.Parameters.AddWithValue("@Fi", finHoy);

                        decimal ventasHoy = Convert.ToDecimal(cmdVentas.ExecuteScalar());

                    
                        lblVentasHoy.Text = $"$ {ventasHoy:N2}";
                    }

                    
                    string queryVisitantes = "SELECT ISNULL(SUM(Cant_bol), 0) FROM TB_VISITANTES WHERE hora_ent >= @In AND hora_ent <= @Fi";
                    using (SqlCommand cmdVisitantes = new SqlCommand(queryVisitantes, conexion))
                    {
                        cmdVisitantes.Parameters.AddWithValue("@In", inicioHoy);
                        cmdVisitantes.Parameters.AddWithValue("@Fi", finHoy);

                        int visitantesHoy = Convert.ToInt32(cmdVisitantes.ExecuteScalar());

                        
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
