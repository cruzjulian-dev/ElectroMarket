using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;
using System.IO;

namespace CapaDatos
{
    public class CD_Backup
    {
        public bool RealizarBackup(string rutaBackup)
        {
            try
            {
                string connectionString = "Data Source=(local);Initial Catalog=DB_ElectroMarket;Integrated Security=True";
                string nombreBaseDatos = "DB_ElectroMarket";

                // Obtener la hora, los minutos y los segundos actuales
                DateTime fechaActual = DateTime.Now;
                int anio = fechaActual.Year;
                int mes = fechaActual.Month;
                int dia = fechaActual.Day;
                int horas = fechaActual.Hour;
                int minutos = fechaActual.Minute;
                int segundos = fechaActual.Second;

                // Eliminar la extensión .bak si existe
                if (Path.GetExtension(rutaBackup).Equals(".bak", StringComparison.OrdinalIgnoreCase))
                {
                    rutaBackup = Path.ChangeExtension(rutaBackup, null);
                }

                string rutaFechaHora = rutaBackup + "_" + dia + "-" + mes + "-" + anio + "__" + horas + "-" + minutos + "-" + segundos + ".bak";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = $"BACKUP DATABASE {nombreBaseDatos} TO DISK = '{rutaFechaHora}'";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

