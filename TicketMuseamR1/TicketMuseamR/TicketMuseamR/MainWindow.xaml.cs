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
            MainFrame.Navigate(new Uri("AdminPage.xaml", UriKind.Relative));
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();

            // 2. Buscar la ventana principal que está sosteniendo esta página actual
            Window ventanaPrincipal = Window.GetWindow(this);

            // 3. Si la encontró, cerramos esa ventana contenedora por completo
            if (ventanaPrincipal != null)
            {
                ventanaPrincipal.Close();
            }
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            // Evita que guarde historial innecesario en memoria
            MainFrame.NavigationService.RemoveBackEntry();
        }
    }
}