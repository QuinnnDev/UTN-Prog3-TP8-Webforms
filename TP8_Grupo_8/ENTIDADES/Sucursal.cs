using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Sucursal
    {
        private String NombreSucursal;
        private String DescripcionSucursal;
        private int    IdHorarioSucursal;
        private int    IdProvinciaSucursal;
        private String DireccionSucursal;
        private String UrlImagen_Sucursal;
        

        public string getNombreSucursal()
        {
            return NombreSucursal;
        }

        public void setNombreSucursal(string nombre)
        {
            NombreSucursal = nombre;
        }

        public string getDescripcionSucursal()
        {
            return DescripcionSucursal;
        }

        public void setDescripcionSucursal(string descripcion)
        {
            DescripcionSucursal = descripcion;
        }

        public int getIdHorarioSucursal()
        {
            return IdHorarioSucursal;
        }
        public void setIdHorarioSucursal(int id)
        {
            IdHorarioSucursal = id;
        }

        public int getIdProvinciaSucursal()
        {
            return IdProvinciaSucursal;
        }
        public void setIdProvinciaSucursal(int id)
        {
            IdProvinciaSucursal = id;
        }

        public string getDireccionSucursal() 
        {
            return DireccionSucursal;
        }

        public void setDireccionSucursal(string direccion)
        {
            DireccionSucursal = direccion;
        }

        public string getImagenUrl()
        {
            return UrlImagen_Sucursal;
        }
        public void setImagenUrl(string url)
        {
            UrlImagen_Sucursal = url;
        }


    }
}
