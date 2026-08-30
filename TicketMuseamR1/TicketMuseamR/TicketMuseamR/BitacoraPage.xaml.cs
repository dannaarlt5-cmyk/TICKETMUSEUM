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

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            
            txtBuscar.Text = string.Empty;
            CargarBitacora();
        }

       
        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            CargarBitacora(txtBuscar.Text.Trim());
        }

       
        private void CargarBitacora(string filtroNombre = "")
        {
            string query = "SELECT Id_visita, Nom_visita, Cant_bol, hora_ent FROM TB_VISITANTES ";

            if (!string.IsNullOrEmpty(filtroNombre))
            {
                query += "WHERE Nom_visita LIKE @Filtro ";
            }

            query += "ORDER BY Id_visita DESC";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        if (!string.IsNullOrEmpty(filtroNombre))
                        {
                            comando.Parameters.AddWithValue("@Filtro", "%" + filtroNombre + "%");
                        }

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaVisitantes = new DataTable();

                        adaptador.Fill(tablaVisitantes);
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
