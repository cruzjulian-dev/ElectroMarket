using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;

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

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = $"BACKUP DATABASE {nombreBaseDatos} TO DISK = '{rutaBackup}'";
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

