using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDADES;

namespace NEGOCIO
{
   public class NegocioSucursal
    {
        public bool agregarSucursal(String nombre)
        {
            int cantFilas = 0;
            Sucursal sucu = new Sucursal();
            sucu.setNombreSucursal(nombre);

            DaoSucursal dao = new DaoSucursal();
            if (dao.existeSucursal(sucu) == false)
            {
                cantFilas = dao.agregarSucursal(sucu);
            }
            if (cantFilas == 1)
                return true;
            else
                return false;
        }


        public DataTable getSucursalById(int id)
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getSucursal(id);
        }

        public DataTable GetTabla(){ 
            DaoSucursal dao =new DaoSucursal();
            return dao.getTablaSucursales();
        }
    }
}
