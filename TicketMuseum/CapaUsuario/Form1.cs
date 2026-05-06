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
            
            string usuarioCorrecto = "admin";
            string contrasenaCorrecta = "1234";
            string user = tbUsuario.Text;
            string pass = tbContrasena.Text;

         
            if (user == "Usuario" || string.IsNullOrWhiteSpace(user) ||
                pass == "Contraseña" || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos vacíos",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

           
            if (user == usuarioCorrecto && pass == contrasenaCorrecta)
            {
                
                Inicio inicio = new Inicio();
                inicio.FormClosed += (s, args) => this.Show();
                inicio.Show();
                this.Hide();
                tbUsuario.Text = "Usuario";
                tbContrasena.Clear();
            }
            else
            {
               
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbContrasena.Clear();
                tbContrasena.Focus(); 
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