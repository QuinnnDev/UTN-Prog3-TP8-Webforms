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
           bool filasAfectadas = eliminarSucursal(Convert.ToInt32(tbxEliminarSucursal.Text));
           
           if (filasAfectadas){ 
                lblMensaje.Text = "Se ha eliminado correctamente";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
           else{ 
                lblMensaje.Text = "ocurrio un error";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private bool eliminarSucursal(int ID)
        {
            NegocioSucursal ns = new NegocioSucursal();
            int filasAfectadas = ns.eliminarSucursal(ID);
            
            return filasAfectadas > 0;
        }
    }
}