using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PROYECTO_MAD.CONEXIÓN
{
    class Conexion
    {
        static public SqlConnection con;
        static public IDbConnection db;

        static public void Connect()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            if (db.State == ConnectionState.Closed)
                db.Open();
        }

        static public void Disconnect()
        {
            db.Close();
        }
    }
}
