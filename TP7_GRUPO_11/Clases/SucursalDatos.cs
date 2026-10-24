using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP7_GRUPO_11.Clases
{
    public class SucursalDatos
    {
        public DataSet ObtenerSucursales()
        {
            DataSet dataset = new DataSet();

            Conexion conexion = new Conexion();
            SqlConnection sqlConnection = conexion.ObtenerConexion();

            sqlConnection.Open();

            string consulta = "SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [Id_ProvinciaSucursal], [URL_Imagen_Sucursal] FROM [Sucursal] ORDER BY [NombreSucursal]";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, sqlConnection);

            sqlDataAdapter.Fill(dataset, "Sucursal");

            sqlConnection.Close();

            return dataset;
        }

        public DataSet BuscarSucursales(string nombre)
        {
            DataSet dataset = new DataSet();

            Conexion conexion = new Conexion();
            SqlConnection sqlConnection = conexion.ObtenerConexion();

            sqlConnection.Open();

            string consulta = "SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [Id_ProvinciaSucursal], [URL_Imagen_Sucursal] FROM [Sucursal] WHERE [NombreSucursal] LIKE @Nombre ORDER BY [NombreSucursal]";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, sqlConnection);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

            sqlDataAdapter.Fill(dataset, "Sucursal");

            sqlConnection.Close();

            return dataset;
        }
    }
}