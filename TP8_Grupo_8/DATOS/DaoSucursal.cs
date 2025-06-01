using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos();
        public void ArmarParametrosSucursalAgregar(ref SqlCommand Comando, Sucursal suc)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NOMBRESUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = suc.NombreSucursal;

            SqlParametros = Comando.Parameters.Add("@DESCRIPCIONSUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = suc.DescripcionSucursal;

            SqlParametros = Comando.Parameters.Add("@ID_HORARIOSUCURSAL", SqlDbType.Int);
            SqlParametros.Value = suc.IdHorarioSucursal;

            SqlParametros = Comando.Parameters.Add("@ID_PROVINCIASUCURSAL", SqlDbType.Int);
            SqlParametros.Value = suc.IdProvinciaSucursal;

            SqlParametros = Comando.Parameters.Add("@DIRECCIONSUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = suc.DireccionSucursal;

            SqlParametros = Comando.Parameters.Add("@URL_IMAGEN_SUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = suc.UrlImagen_Sucursal;
        }

        public int agregarSucursal(Sucursal suc)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, suc);
            return ds.EjecProcedimAlmacenado(comando, "spAgregarSucursal");
        }
        public Boolean existeSucursal(Sucursal suc)
        {
       
            Sucursal sucu = new Sucursal();
            AccesoDatos ds = new AccesoDatos();

            String consulta = "Select * from Sucursal where NombreSucursal='" + suc.getNombreSucursal() + "'";
            return ds.Existe(consulta);
        }

        public DataTable getTablaSucursales()
        {
            DataTable tabla = ds.ObtenerTabla("Sucursal", "Select * from Sucursales");
            return tabla;
        }

    }
}
