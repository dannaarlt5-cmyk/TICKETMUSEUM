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

        // Botón Acceder
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Puedes cambiar "admin" y "123" por los accesos que prefieras
            if (txtUsuario.Text == "admin" && txtContrasena.Password == "123")
            {
                MessageBox.Show("¡Bienvenido al sistema TicketMuseum!", "Acceso Concedido", MessageBoxButton.OK, MessageBoxImage.Information);

                // Abrir el Dashboard principal
                MainWindow dashboard = new MainWindow();
                dashboard.Show();

                this.Close(); // Cierra la ventana de Login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
