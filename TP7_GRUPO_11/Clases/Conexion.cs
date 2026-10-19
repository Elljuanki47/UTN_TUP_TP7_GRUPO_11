using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP7_GRUPO_11.Clases
{
    public class Conexion
    {

        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True");

            return conexion;
        }

    }
}