using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    internal class AccesoDatos
    {
        string stringConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection sqlConnection = new SqlConnection(stringConexion);
            try
            {
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public SqlDataAdapter ObtenerAdapdator(string consultaSQL)
        {
            SqlDataAdapter sqlAdapter;
            try
            {
                sqlAdapter = new SqlDataAdapter(consultaSQL, ObtenerConexion());
                return sqlAdapter;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(string nombreTabla, string consultaSQL)
        {
            DataSet dataSet = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter sqlDataAdapter = datos.ObtenerAdapdator(consultaSQL);
            sqlDataAdapter.Fill(dataSet, nombreTabla);
            return dataSet.Tables[nombreTabla];
        }

        public int ObtenerMaximo(string nombreCampo, string nombreTabla)
        {
            string consultaSQL = $"SELECT ISNULL(MAX({nombreCampo}), 0) AS Maximo FROM {nombreTabla}";

            DataTable tabla = ObtenerTabla(nombreTabla, consultaSQL);

            if (tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0]["Maximo"]) + 1;
            }

            return 0; 
        }

    }
}
