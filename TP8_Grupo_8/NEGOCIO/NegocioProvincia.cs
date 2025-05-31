using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using DATOS;


namespace NEGOCIO
{
    public class NegocioProvincia
    {
        public DataTable getTabla()
        {
            DaoProvincia dao = new DaoProvincia();
            return dao.getTablaProvincia();
        }
    }
}
