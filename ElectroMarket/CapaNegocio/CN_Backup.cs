using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Backup
    {
        public bool RealizarBackup(string rutaBackup)
        {
            CD_Backup backupBD = new CD_Backup();
            return backupBD.RealizarBackup(rutaBackup);
        }
    }
}
