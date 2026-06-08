using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para BitacoraPage.xaml
    /// </summary>
    public partial class BitacoraPage : Page
    {
        private string conexionString = @"Server=(local)\SQLEXPRESS;Database=BDMUSEO;Integrated Security=True; TrustServerCertificate=True";
        public BitacoraPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CargarBitacora();
        }

        // Evento del botón para recargar la tabla manualmente
        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            CargarBitacora();
        }
      
        // Método principal para conectar a SQL y rellenar el DataGrid
        private void CargarBitacora()
        {
            // Consulta SQL para traer los registros de TB_VISITANTES (Ordenados del más reciente al más antiguo)
            string query = "SELECT Id_visita, Nom_visita, Cant_bol, hora_ent FROM TB_VISITANTES ORDER BY Id_visita DESC";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaVisitantes = new DataTable();

                        // Llenamos el DataTable en memoria con los datos del servidor
                        adaptador.Fill(tablaVisitantes);

                        // Enlazamos la tabla de SQL directamente a tu DataGrid visual
                        dgVisitantes.ItemsSource = tablaVisitantes.DefaultView;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la bitácora desde SQL Server: " + ex.Message, "Error de Conexión", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
