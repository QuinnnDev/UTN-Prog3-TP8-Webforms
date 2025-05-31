using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
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
	}
}