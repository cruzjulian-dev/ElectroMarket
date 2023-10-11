using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Restaurar
    {
        public bool RestaurarBD(string rutaBackup)
        {
            try
            {
                string connectionString = "Data Source=(local);Initial Catalog=DB_ElectroMarket;Integrated Security=True"; 
                string nombreBaseDatos = "DB_ElectroMarket"; 

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string str = "USE master;";
                    string str2 = "ALTER DATABASE " + nombreBaseDatos + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    string str3 = "RESTORE DATABASE " + nombreBaseDatos + " FROM DISK = '" + rutaBackup + "' WITH REPLACE;";
                    //string sql = $"USE master; GO; RESTORE DATABASE {nombreBaseDatos} FROM DISK = '{rutaBackup}'";
                    SqlCommand cmd = new SqlCommand(str, connection);
                    SqlCommand cmd2 = new SqlCommand(str2, connection);
                    SqlCommand cmd3 = new SqlCommand(str3, connection);

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();

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
