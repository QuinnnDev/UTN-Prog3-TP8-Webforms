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
            lblMensaje.ForeColor = System.Drawing.Color.Black;
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
           bool filasAfectadas = eliminarSucursal(Convert.ToInt32(tbxEliminarSucursal.Text));
           
           if (filasAfectadas){ 
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Text = "Se ha eliminado correctamente";
            }
           else{ 
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "No existe una sucursal con ese ID";
            }
            tbxEliminarSucursal.Text = string.Empty;
        }

        private bool eliminarSucursal(int ID)
        {
            NegocioSucursal ns = new NegocioSucursal();
            int filasAfectadas = ns.eliminarSucursal(ID);
            
            return filasAfectadas > 0;
        }
    }
}