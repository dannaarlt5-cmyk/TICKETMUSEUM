using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicketMuseamR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Uri("InicioPage.xaml", UriKind.Relative));
        }
        private void NavInicio_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("InicioPage.xaml", UriKind.Relative));
        }

        private void NavVentas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("VentasPage.xaml", UriKind.Relative));
        }

        private void NavBitacora_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("BitacoraPage.xaml", UriKind.Relative));
        }

        private void NavAdmin_Click(object sender, RoutedEventArgs e)
        {
            // Apunta a la página de administración de Danna cuando esté lista como Page
            // MainFrame.Navigate(new Uri("AdminPage.xaml", UriKind.Relative));
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close(); // Este sí cierra la aplicación completa para volver al Login
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            // Evita que guarde historial innecesario en memoria
            MainFrame.NavigationService.RemoveBackEntry();
        }
    }
}