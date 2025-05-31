using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using ENTIDADES;
using DATOS;

namespace VISTAS
{
	public partial class AgregarSucursal : System.Web.UI.Page
	{
		NegocioProvincia np = new NegocioProvincia();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				ddlProvincias.DataSource = np.getTabla();
                ddlProvincias.DataTextField = "DescripcionProvincia";
                ddlProvincias.DataValueField = "Id_Provincia";
                ddlProvincias.DataBind();
            }
		}

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Sucursal newSucursal = new Sucursal();

            DaoSucursal dao = new DaoSucursal();

            newSucursal.setNombreSucursal(txtNombre.Text);
            newSucursal.DescripcionSucursal = txtDescripcion.Text;
            newSucursal.IdProvinciaSucursal = int.Parse(ddlProvincias.SelectedValue);
            newSucursal.DireccionSucursal = txtDireccion.Text;
            newSucursal.UrlImagen_Sucursal = "sin-imagen.png";


            if (dao.existeSucursal(newSucursal) == false)
            {
                dao.agregarSucursal(newSucursal);
            }
          
        }
    }
}