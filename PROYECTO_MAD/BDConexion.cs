﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD
{
    public class BDConexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_MAD;Data Source=DESKTOP-PC9LLTV\\SQLEXPRESS");

            conexion.Open();
            return conexion;
        }
    }
}