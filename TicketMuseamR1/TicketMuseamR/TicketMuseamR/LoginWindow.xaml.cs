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

namespace TicketMuseamR
{
    /// <summary>
    /// Lógica de interacción para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtUsuario.Text == "admin" && txtContrasena.Password == "123")
            {
                MessageBox.Show("¡Bienvenido al sistema TicketMuseum!", "Acceso Concedido", MessageBoxButton.OK, MessageBoxImage.Information);


                MainWindow dashboard = new MainWindow();
                dashboard.Show();

                this.Close(); 
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void txtOlvidaste_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string mensaje = "🔐 Restablecimiento de Credenciales\n\n" +
                             "Por motivos de seguridad informática y auditoría del Ticket Museum, " +
                             "las contraseñas de los usuarios deben ser modificadas directamente por el administrador del sistema.\n\n" +
                             "📞 Comunícate con Soporte Técnico o con el Administrador de Turno para solicitar tu clave temporal.";

            MessageBox.Show(mensaje, "Soporte de Accesos", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
