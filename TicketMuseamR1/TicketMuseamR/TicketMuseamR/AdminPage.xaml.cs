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
            // Inicializar los filtros con la fecha de hoy por defecto al entrar
            dpDesde.SelectedDate = DateTime.Today;
            dpHasta.SelectedDate = DateTime.Today;

            CargarDatosPorFecha();
        }

        // Cada vez que el usuario cambie una fecha, se refresca todo automáticamente
        private void FiltroFecha_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            CargarDatosPorFecha();
        }

        // Botón rápido para regresar a ver el día de hoy
        private void BtnHoy_Click(object sender, RoutedEventArgs e)
        {
            dpDesde.SelectedDate = DateTime.Today;
            dpHasta.SelectedDate = DateTime.Today;
        }

        // MÉTODO MAESTRO: Calcula montos y boletos basados en las fechas seleccionadas
        private void CargarDatosPorFecha()
        {
            // Validar que los objetos visuales ya existan
            if (dpDesde == null || dpHasta == null || lblTotalRecaudado == null || lblTotalBoletos == null || dgVentas == null) return;

            // Obtener fechas seleccionadas (si están vacías toma el día de hoy)
            DateTime fechaInicio = dpDesde.SelectedDate ?? DateTime.Today;
            DateTime fechaFin = dpHasta.SelectedDate ?? DateTime.Today;

            // Ajustar fecha fin al último segundo del día (23:59:59) para que incluya todo lo de ese día
            fechaFin = fechaFin.Date.AddDays(1).AddSeconds(-1);

            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();

                    // 1. DINERO RECAUDADO FILTRADO POR FECHA
                    string queryDinero = "SELECT ISNULL(SUM(Monto_total), 0) FROM TB_VENTAS WHERE Fecha_venta >= @Inicio AND Fecha_venta <= @Fin";
                    using (SqlCommand cmdDinero = new SqlCommand(queryDinero, conexion))
                    {
                        cmdDinero.Parameters.AddWithValue("@Inicio", fechaInicio);
                        cmdDinero.Parameters.AddWithValue("@Fin", fechaFin);
                        decimal totalDinero = Convert.ToDecimal(cmdDinero.ExecuteScalar());
                        lblTotalRecaudado.Text = $"$ {totalDinero:F2}";
                    }

                    // 2. BOLETOS EMITIDOS FILTRADOS POR FECHA
                    string queryBoletos = "SELECT ISNULL(SUM(Cant_bol), 0) FROM TB_VISITANTES WHERE hora_ent >= @Inicio AND hora_ent <= @Fin";
                    using (SqlCommand cmdBoletos = new SqlCommand(queryBoletos, conexion))
                    {
                        cmdBoletos.Parameters.AddWithValue("@Inicio", fechaInicio);
                        cmdBoletos.Parameters.AddWithValue("@Fin", fechaFin);
                        int totalBoletos = Convert.ToInt32(cmdBoletos.ExecuteScalar());
                        lblTotalBoletos.Text = $"{totalBoletos} Boletos";
                    }

                    // 3. ACTUALIZAR EL HISTORIAL DEL DATAGRID CON EL FILTRO
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

        // ACCIÓN REAL DEL CORTE DE CAJA
        private void BtnCorteCaja_Click(object sender, RoutedEventArgs e)
        {
            DateTime inicioHoy = DateTime.Today;
            DateTime finHoy = DateTime.Today.AddDays(1).AddSeconds(-1);

            try
            {
                decimal totalEfectivo = 0;
                decimal totalTarjeta = 0;
                int totalBoletosHoy = 0;

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();

                    // Sumar Efectivo de hoy
                    string qEfectivo = "SELECT ISNULL(SUM(Monto_total), 0) FROM TB_VENTAS WHERE Metodo_pago = 'Efectivo' AND Fecha_venta >= @In AND Fecha_venta <= @Fi";
                    using (SqlCommand cmd = new SqlCommand(qEfectivo, conexion))
                    {
                        cmd.Parameters.AddWithValue("@In", inicioHoy);
                        cmd.Parameters.AddWithValue("@Fi", finHoy);
                        totalEfectivo = Convert.ToDecimal(cmd.ExecuteScalar());
                    }

                    // Sumar Tarjeta de hoy
                    string qTarjeta = "SELECT ISNULL(SUM(Monto_total), 0) FROM TB_VENTAS WHERE Metodo_pago = 'Tarjeta' AND Fecha_venta >= @In AND Fecha_venta <= @Fi";
                    using (SqlCommand cmd = new SqlCommand(qTarjeta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@In", inicioHoy);
                        cmd.Parameters.AddWithValue("@Fi", finHoy);
                        totalTarjeta = Convert.ToDecimal(cmd.ExecuteScalar());
                    }

                    // Sumar boletos de hoy
                    string qBoletos = "SELECT ISNULL(SUM(Cant_bol), 0) FROM TB_VISITANTES WHERE hora_ent >= @In AND hora_ent <= @Fi";
                    using (SqlCommand cmd = new SqlCommand(qBoletos, conexion))
                    {
                        cmd.Parameters.AddWithValue("@In", inicioHoy);
                        cmd.Parameters.AddWithValue("@Fi", finHoy);
                        totalBoletosHoy = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                decimal granTotal = totalEfectivo + totalTarjeta;

                // ¡AQUÍ ESTÁ LA MAGIA!
                // Creamos la ventana de vista previa pasándole los datos calculados de las consultas
                ReporteWindow ventanaPDF = new ReporteWindow(totalEfectivo, totalTarjeta, granTotal, totalBoletosHoy);

                // Bloquea el resto de la app hasta que interactúes con el reporte
                ventanaPDF.ShowDialog();

                // Una vez cerrada la ventana, actualizamos los paneles por si acaso
                CargarDatosPorFecha();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recopilar datos para el reporte visual: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}


