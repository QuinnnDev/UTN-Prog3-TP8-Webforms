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

        public Sucursal getSucursal(int id)
        {

            Sucursal suc = new Sucursal(); 

            DataTable tabla = ds.ObtenerTabla("Sucursal", "Select * from sucursal where Id_Sucursal=" + id);
            suc.IdSucursal = (Convert.ToInt32(tabla.Rows[0][0].ToString()));
            suc.NombreSucursal = (tabla.Rows[0][1].ToString());
            suc.DescripcionSucursal = (tabla.Rows[0][2].ToString());
            suc.IdHorarioSucursal = (Convert.ToInt32(tabla.Rows[0][3]));
            suc.IdProvinciaSucursal = (Convert.ToInt32(tabla.Rows[0][4]));
            suc.DireccionSucursal = (tabla.Rows[0][5].ToString());
            suc.UrlImagen_Sucursal = (tabla.Rows[0][6].ToString());

            return suc;
        }

        public Sucursal getSucursal(Sucursal suc)
        {
            DataTable tabla = ds.ObtenerTabla("Sucursal", "Select * from sucursal where Id_Sucursal=" + suc.IdSucursal);
            suc.IdSucursal =  (Convert.ToInt32(tabla.Rows[0][0].ToString()));
            suc.NombreSucursal = (tabla.Rows[0][1].ToString());
            suc.DescripcionSucursal = (tabla.Rows[0][2].ToString());
            suc.IdHorarioSucursal = (Convert.ToInt32(tabla.Rows[0][3]));
            suc.IdProvinciaSucursal = (Convert.ToInt32(tabla.Rows[0][4]));
            suc.DireccionSucursal = (tabla.Rows[0][5].ToString());
            suc.UrlImagen_Sucursal = (tabla.Rows[0][6].ToString());

            return suc;
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
