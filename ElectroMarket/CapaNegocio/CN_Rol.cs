﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol objCd_Rol = new CD_Rol();

        public List<Rol> Listar()
        {
            return objCd_Rol.Listar();
        }
    }
}
