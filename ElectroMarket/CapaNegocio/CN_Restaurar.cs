using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Restaurar
    {
        public bool RestaurarBackup(string rutaBackup)
        {
            CD_Restaurar restaurarBD = new CD_Restaurar();
            return restaurarBD.RestaurarBD(rutaBackup);
        }
        
    }
}
