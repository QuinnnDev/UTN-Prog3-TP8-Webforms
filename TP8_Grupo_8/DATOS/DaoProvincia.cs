using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;

namespace DATOS
{
    internal class DaoProvincia
    {
        AccesoDatos datos = new AccesoDatos();

        public DataTable getTablaProvincia()
        {
            DataTable tabla = datos.ObtenerTabla("Provincia", "SELECT * FROM Provincia");
            return tabla;
        }
    }
}
