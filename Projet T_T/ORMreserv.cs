using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_T_T
{
    public class ORMreserv
    {
        private static MySqlConnection conn = null;
        private static MySqlCommand cmd = null;
        private static MySqlDataReader reader = null;

        public static bool Connexion()
        {
            String cs = @"server=localhost;userid=root;password=;database=restaurant";
            conn = new MySqlConnection(cs);
            conn.Open();
            return (conn.State == ConnectionState.Open);

        }
        public static bool Deconnexion()
        {
            conn.Close();
            return (conn.State == ConnectionState.Closed);
        }
    }
}
