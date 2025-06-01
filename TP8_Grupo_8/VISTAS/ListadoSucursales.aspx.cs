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
        private void CargarGridView()
        {

            NegocioSucursal sucu = new NegocioSucursal();
            DataTable tablaSucursales = sucu.GetTabla();
            gvSucursales.DataSource = tablaSucursales;
            gvSucursales.DataBind();

        }

        private void FiltrarGridView()
        {
            NegocioSucursal sucu = new NegocioSucursal();

            DataTable tabla = sucu.getSucursalById(Convert.ToInt32(txtBuscarID.Text));
            gvSucursales.DataSource = tabla;
            gvSucursales.DataBind();
        }

		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                CargarGridView();
            }
		}


        protected void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarGridView();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {

            if(txtBuscarID.Text.Trim() != "")
            {

                FiltrarGridView();
                txtBuscarID.Text = string.Empty;

            }
            else
            {
                CargarGridView();
            }


        }



    }
}