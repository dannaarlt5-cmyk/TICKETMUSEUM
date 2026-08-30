using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
    /// Lógica de interacción para AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        private string conexionString = @"Server=(local)\SQLEXPRESS;Database=BDMUSEO;Integrated Security=True; TrustServerCertificate=True";

        public AdminPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            dpDesde.SelectedDate = DateTime.Today;
            dpHasta.SelectedDate = DateTime.Today;

            CargarDatosPorFecha();
        }

       
        private void FiltroFecha_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            CargarDatosPorFecha();
        }

        
        private void BtnHoy_Click(object sender, RoutedEventArgs e)
        {
            dpDesde.SelectedDate = DateTime.Today;
            dpHasta.SelectedDate = DateTime.Today;
        }

      
        private void CargarDatosPorFecha()
        {
            if (dpDesde == null || dpHasta == null || lblTotalRecaudado == null || lblTotalBoletos == null || dgVentas == null) return;

            DateTime fechaInicio = dpDesde.SelectedDate ?? DateTime.Today;
            DateTime fechaFin = dpHasta.SelectedDate ?? DateTime.Today;

           
            fechaFin = fechaFin.Date.AddDays(1).AddSeconds(-1);

            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();

                    
                    string queryDinero = "SELECT ISNULL(SUM(Monto_total), 0) FROM TB_VENTAS WHERE Fecha_venta >= @Inicio AND Fecha_venta <= @Fin";
                    using (SqlCommand cmdDinero = new SqlCommand(queryDinero, conexion))
                    {
                        cmdDinero.Parameters.AddWithValue("@Inicio", fechaInicio);
                        cmdDinero.Parameters.AddWithValue("@Fin", fechaFin);
                        decimal totalDinero = Convert.ToDecimal(cmdDinero.ExecuteScalar());
                        lblTotalRecaudado.Text = $"$ {totalDinero:N2}";
                    }

                   
                    string queryBoletos = "SELECT ISNULL(SUM(Cant_bol), 0) FROM TB_VISITANTES WHERE hora_ent >= @Inicio AND hora_ent <= @Fin";
                    using (SqlCommand cmdBoletos = new SqlCommand(queryBoletos, conexion))
                    {
                        cmdBoletos.Parameters.AddWithValue("@Inicio", fechaInicio);
                        cmdBoletos.Parameters.AddWithValue("@Fin", fechaFin);
                        int totalBoletos = Convert.ToInt32(cmdBoletos.ExecuteScalar());
                        lblTotalBoletos.Text = $"{totalBoletos} Boletos";
                    }

                    
                    string queryHistorial = "SELECT Id_venta, Monto_total, Metodo_pago, Fecha_venta FROM TB_VENTAS " +
                                           "WHERE Fecha_venta >= @Inicio AND Fecha_venta <= @Fin ORDER BY Id_venta DESC";
                    using (SqlCommand cmdGrid = new SqlCommand(queryHistorial, conexion))
                    {
                        cmdGrid.Parameters.AddWithValue("@Inicio", fechaInicio);
                        cmdGrid.Parameters.AddWithValue("@Fin", fechaFin);

                        SqlDataAdapter adaptador = new SqlDataAdapter(cmdGrid);
                        DataTable tablaVentas = new DataTable();
                        adaptador.Fill(tablaVentas);
                        dgVentas.ItemsSource = tablaVentas.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los datos por fecha: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

       
        private void BtnCorteCaja_Click(object sender, RoutedEventArgs e)
        {
            EjecutarReportePorRango(DateTime.Today, DateTime.Today);
        }

       
        private void BtnReporteRango_Click(object sender, RoutedEventArgs e)
        {
            DateTime fechaInicio = dpDesde.SelectedDate ?? DateTime.Today;
            DateTime fechaFin = dpHasta.SelectedDate ?? DateTime.Today;

            EjecutarReportePorRango(fechaInicio, fechaFin);
        }

       
        private void EjecutarReportePorRango(DateTime inicio, DateTime fin)
        {
            
            DateTime finAjustado = fin.Date.AddDays(1).AddSeconds(-1);
            DateTime inicioAjustado = inicio.Date;

            try
            {
                decimal totalEfectivo = 0;
                decimal totalTarjeta = 0;
                int totalBoletosRango = 0;

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();

                   
                    string qEfectivo = "SELECT ISNULL(SUM(Monto_total), 0) FROM TB_VENTAS WHERE Metodo_pago = 'Efectivo' AND Fecha_venta >= @In AND Fecha_venta <= @Fi";
                    using (SqlCommand cmd = new SqlCommand(qEfectivo, conexion))
                    {
                        cmd.Parameters.AddWithValue("@In", inicioAjustado);
                        cmd.Parameters.AddWithValue("@Fi", finAjustado);
                        totalEfectivo = Convert.ToDecimal(cmd.ExecuteScalar());
                    }

                    string qTarjeta = "SELECT ISNULL(SUM(Monto_total), 0) FROM TB_VENTAS WHERE Metodo_pago = 'Tarjeta' AND Fecha_venta >= @In AND Fecha_venta <= @Fi";
                    using (SqlCommand cmd = new SqlCommand(qTarjeta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@In", inicioAjustado);
                        cmd.Parameters.AddWithValue("@Fi", finAjustado);
                        totalTarjeta = Convert.ToDecimal(cmd.ExecuteScalar());
                    }

                   
                    string qBoletos = "SELECT ISNULL(SUM(Cant_bol), 0) FROM TB_VISITANTES WHERE hora_ent >= @In AND hora_ent <= @Fi";
                    using (SqlCommand cmd = new SqlCommand(qBoletos, conexion))
                    {
                        cmd.Parameters.AddWithValue("@In", inicioAjustado);
                        cmd.Parameters.AddWithValue("@Fi", finAjustado);
                        totalBoletosRango = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                decimal granTotal = totalEfectivo + totalTarjeta;

               
                ReporteWindow ventanaPDF = new ReporteWindow(totalEfectivo, totalTarjeta, granTotal, totalBoletosRango);
                ventanaPDF.ShowDialog();

                CargarDatosPorFecha();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recopilar datos para el reporte visual: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}


