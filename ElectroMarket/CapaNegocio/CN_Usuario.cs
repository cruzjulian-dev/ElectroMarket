﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objCd_Usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return objCd_Usuario.Listar();
        }
    }
}
