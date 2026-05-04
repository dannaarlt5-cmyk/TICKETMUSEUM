using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMuseum.CapaUsuario
{
    public partial class Administración : Form
    {
        public Administración()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
