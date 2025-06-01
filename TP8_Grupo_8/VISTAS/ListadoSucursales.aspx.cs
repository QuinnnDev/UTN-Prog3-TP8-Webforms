using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using NEGOCIO;
using DATOS;

namespace VISTAS
{
	public partial class ListadoSucursales : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                CargarGridView();
            }
		}

        void CargarGridView()
        {

            NegocioSucursal sucu = new NegocioSucursal();
            DataTable tablaSucursales = sucu.GetTabla();
            gvSucursales.DataSource = tablaSucursales;
            gvSucursales.DataBind();

        }

        protected void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarGridView();
        }
    }
}