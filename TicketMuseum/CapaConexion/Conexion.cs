using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TicketMuseum.CapaConexion
{
    public class Conexion
    {
        public static SqlConnection Leer()
        {
            SqlConnection cn = new SqlConnection(@"Server=(local)\SQLEXPRESS;Database=BDMUSEO;Integrated Security=True; TrustServerCertificate=True");
            return cn;
        }
    }
}
