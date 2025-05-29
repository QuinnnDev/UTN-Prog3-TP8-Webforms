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
    }
}
