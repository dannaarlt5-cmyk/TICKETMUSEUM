namespace TicketMuseum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Eventos Usuario Y Contraseña
        private void btAcceder_Click(object sender, EventArgs e)
        {
            // 1. Definimos las credenciales válidas (puedes cambiarlas aquí)
            string usuarioCorrecto = "admin";
            string contrasenaCorrecta = "1234";

            // 2. Obtenemos lo que el usuario escribió en los TextBox
            string user = tbUsuario.Text;
            string pass = tbContrasena.Text;

            // 3. Validamos que no entren con los campos vacíos o con el texto por defecto
            if (user == "Usuario" || string.IsNullOrWhiteSpace(user) ||
                pass == "Contraseña" || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos vacíos",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método para que no intente entrar
            }

            // 4. Comprobamos si las credenciales coinciden
            if (user == usuarioCorrecto && pass == contrasenaCorrecta)
            {
                // SI SON CORRECTOS: Abrimos el formulario Inicio
                Inicio inicio = new Inicio();
                inicio.FormClosed += (s, args) => this.Show();
                inicio.Show();
                this.Hide();
            }
            else
            {
                // SI SON INCORRECTOS: Mostramos error y limpiamos la contraseña
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbContrasena.Clear();
                tbContrasena.Focus(); // Ponemos el cursor listo para reintentar
            }
        }
        private void tbUsuario_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Usuario")
                tbUsuario.Clear();
        }
        private void tbContrasena_Click(object sender, EventArgs e)
        {
            if (tbContrasena.Text == "Contraseña")
            {
                tbContrasena.Clear();
                tbContrasena.UseSystemPasswordChar = false;
            }
        }
        private void tbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btMostrar_Click(object sender, EventArgs e)
        {
            if (tbContrasena.Text != "Contraseña")
                tbContrasena.UseSystemPasswordChar = !tbContrasena.UseSystemPasswordChar;
        }
        private void tbContrasena_Enter(object sender, EventArgs e)
        {
            tbContrasena.UseSystemPasswordChar = false;
        }
        private void tbContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbContrasena.Text))
            {
                tbContrasena.UseSystemPasswordChar = true;
                tbContrasena.Text = "Contraseña";
            }
        }
        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsuario.Text))
            {
                tbUsuario.Text = "Usuario";
            }
        }
        #endregion

        private void lbC_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Si olvidaste tu contraseña, comunícate con el administrador.\n\n" +
        " Tel: 668-123-4567\n" +
        "Email: admin@sistema.com",
        "Recuperación de acceso",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
           );
        }
    }
}