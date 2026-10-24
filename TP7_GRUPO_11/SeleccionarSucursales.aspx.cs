using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP7_GRUPO_11.Clases;

namespace TP7_GRUPO_11
{
    public partial class SeleccionarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            SucursalDatos datos = new SucursalDatos();

            DataSet dataSet = datos.BuscarSucursales(txtBuscarSucursal.Text);

            lvSucursales.DataSource = dataSet.Tables["Sucursal"];
            lvSucursales.DataBind();
        }
    }
}