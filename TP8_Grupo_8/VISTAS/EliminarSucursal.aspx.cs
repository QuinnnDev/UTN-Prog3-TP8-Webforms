using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DATOS;
using ENTIDADES;
using NEGOCIO;

namespace VISTAS
{
	public partial class EliminarSucursal : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private bool eliminarSucursal(int ID)
        {
            NegocioSucursal ns = new NegocioSucursal();
            int filasAfectadas = ns.eliminarSucursal(ID);
            
            return filasAfectadas > 0;
        }
    }
}