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
using System.Windows.Threading;
using Microsoft.Data.SqlClient;

namespace TicketMuseamR
{
    /// <summary>
    /// Lógica de interacción para VentasPage.xaml
    /// </summary>
    public partial class VentasPage : Page
    {
        private DispatcherTimer timer;
        private const double PRECIO_BOLETO = 50.00;
        private string conexionString = @"Server=(local)\SQLEXPRESS;Database=BDMUSEO;Integrated Security=True; TrustServerCertificate=True";
        public VentasPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            txtFechaAuto.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            txtHoraAuto.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            txtHoraAuto.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void txtCantidadBoletos_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtTotalVenta == null) return;

            if (int.TryParse(txtCantidadBoletos.Text, out int cantidad) && cantidad > 0)
            {
                double total = cantidad * PRECIO_BOLETO;
                txtTotalVenta.Text = $"$ {total:F2}";
            }
            else
            {
                txtTotalVenta.Text = "$ 0.00";
            }
        }

        // REGISTRO ADAPTADO A TUS TABLAS EXACTAS
        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtResponsable.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del responsable del grupo.", "Campos incompletos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(txtCantidadBoletos.Text, out int cantidadBoletos) || cantidadBoletos <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad de boletos válida.", "Error de entrada", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Preparar los datos con tus tipos de datos de SQL
            string nombreResponsable = txtResponsable.Text;
            decimal montoTotal = Convert.ToDecimal(cantidadBoletos * PRECIO_BOLETO);
            string metodoPago = ((ComboBoxItem)cboMetodoPago.SelectedItem).Content.ToString();

            // Como pusiste DEFAULT GETDATE() en hora_ent y Fecha_venta, SQL se encarga de la fecha solo.
            // Así que nuestras consultas solo necesitan mandar los datos obligatorios.
            string queryVisitantes = "INSERT INTO TB_VISITANTES (Nom_visita, Cant_bol) VALUES (@Nom_visita, @Cant_bol);";
            string queryVentas = "INSERT INTO TB_VENTAS (Monto_total, Metodo_pago) VALUES (@Monto_total, @Metodo_pago);";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    // Insertar en TB_VISITANTES
                    using (SqlCommand cmdVisita = new SqlCommand(queryVisitantes, conexion))
                    {
                        cmdVisita.Parameters.AddWithValue("@Nom_visita", nombreResponsable);
                        cmdVisita.Parameters.AddWithValue("@Cant_bol", cantidadBoletos);
                        cmdVisita.ExecuteNonQuery();
                    }

                    // Insertar en TB_VENTAS
                    using (SqlCommand cmdVenta = new SqlCommand(queryVentas, conexion))
                    {
                        cmdVenta.Parameters.AddWithValue("@Monto_total", montoTotal);
                        cmdVenta.Parameters.AddWithValue("@Metodo_pago", metodoPago);
                        cmdVenta.ExecuteNonQuery();
                    }

                    // Mensaje de Éxito
                    MessageBox.Show($"¡Registro completado en BDMUSEO!\n\n" +
                                    $"Tabla Visitantes 👤: Se registró a {nombreResponsable} con {cantidadBoletos} boletos.\n" +
                                    $"Tabla Ventas 💰: Monto de $ {montoTotal:F2} pagado con {metodoPago}.",
                                    "Éxito al Registrar", MessageBoxButton.OK, MessageBoxImage.Information);

                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un problema al guardar en la base de datos: " + ex.Message, "Error de SQL", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarFormulario();
            if (this.NavigationService != null)
            {
                this.NavigationService.Navigate(new Uri("InicioPage.xaml", UriKind.Relative));
            }
        }

        private void LimpiarFormulario()
        {
            txtResponsable.Text = string.Empty;
            txtCantidadBoletos.Text = "1";
            cboMetodoPago.SelectedIndex = 0;
        }
    }

    
}
