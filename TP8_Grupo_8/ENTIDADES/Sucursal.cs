﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Sucursal
    {
        public String NombreSucursal;
        public int    IdSucursal            { get; set; }
        public String DescripcionSucursal   { get; set; }
        public int    IdHorarioSucursal     { get; set; }
        public int    IdProvinciaSucursal   { get; set; }
        public String DireccionSucursal     { get; set; }
        public String UrlImagen_Sucursal    { get; set; }

        public String getNombreSucursal()
        {
            return NombreSucursal;
        }
        public void setNombreSucursal(String nombreSucursal)
        {
            NombreSucursal = nombreSucursal;
        }

    }

}
