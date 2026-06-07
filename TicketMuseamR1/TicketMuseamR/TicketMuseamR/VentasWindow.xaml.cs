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
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;

namespace TicketMuseamR
{
    /// <summary>
    /// Lógica de interacción para VentasWindow.xaml
    /// </summary>
    public partial class VentasWindow : Window
    {
        private string conexionString = @"Server=(local)\SQLEXPRESS;Database=BDMUSEO;Integrated Security=True; TrustServerCertificate=True";
        public VentasWindow()
        {
            InitializeComponent();
            txtTotalVenta.Text = "$ 50.00";
        }
        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // 1. Validaciones básicas
            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del responsable.", "Campos vacíos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(txtCantidadBoletos.Text, out int boletos) || boletos < 1 || boletos > 50)
            {
                MessageBox.Show("La cantidad de boletos debe ser un número entre 1 y 50.", "Cantidad inválida", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // 2. Calcular montos
            decimal costoBoleto = 50.00m;
            decimal montoTotal = boletos * costoBoleto;

            // Obtener método de pago seleccionado en el ComboBox
            string metodoPago = cboMetodoPago.Text;

            // 3. Inserción en la Base de Datos con SQL
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    // Insertar en TB_VISITANTES
                    string queryVisitantes = "INSERT INTO TB_VISITANTES (Nom_visita, Cant_bol) VALUES (@nom, @cant)";
                    using (SqlCommand cmdVis = new SqlCommand(queryVisitantes, conexion))
                    {
                        cmdVis.Parameters.AddWithValue("@nom", txtResponsable.Text);
                        cmdVis.Parameters.AddWithValue("@cant", boletos);
                        cmdVis.ExecuteNonQuery();
                    }

                    // Insertar en TB_VENTAS
                    string queryVentas = "INSERT INTO TB_VENTAS (Monto_total, Metodo_pago) VALUES (@monto, @metodo)";
                    using (SqlCommand cmdVen = new SqlCommand(queryVentas, conexion))
                    {
                        cmdVen.Parameters.AddWithValue("@monto", montoTotal);
                        cmdVen.Parameters.AddWithValue("@metodo", metodoPago);
                        cmdVen.ExecuteNonQuery();
                    }

                    MessageBox.Show($"¡Venta registrada con éxito!\nTotal: ${montoTotal} MXN", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                    // Limpiar campos para la siguiente venta
                    txtResponsable.Clear();
                    txtCantidadBoletos.Text = "1";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error catastrófico", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void NavBitacora_Click(object sender, RoutedEventArgs e)
        {
            BitacoraWindow ventanaBitacora = new BitacoraWindow();
            ventanaBitacora.Show();
            this.Close(); // Cierra la ventana actual de Ventas para no acumular pantallas
        }

        // Evento para abrir la ventana de Administración (Sprint de Danna) desde Ventas
        private void NavAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow ventanaAdmin = new AdminWindow();
            ventanaAdmin.Show();
            this.Close();
        }

        // Evento para cerrar sesión y regresar al Login
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Cierra la pantalla de registro
        }
    }
}
