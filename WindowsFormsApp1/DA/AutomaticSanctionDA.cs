using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.DA
{
    public static class AutomaticSanctionDA
    {

        public static ArrayList GetSettings()
        {
            ArrayList settings = new ArrayList();
            MySqlConnection connection = Database.OpenConnection();

            string query = "SELECT * FROM automaticsanctions";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int lateCount = reader.GetInt32("LateCount");
                string soort = reader.GetString("Soort");
                int status = reader.GetInt32("Status");

                ArrayList row = new ArrayList();
                row.Add(lateCount);
                row.Add(soort);
                row.Add(status);

                settings.Add(row);
            }

            Database.CloseConnection();
            return settings;
        }

        public static void SaveSettings(ArrayList arr)
        {
            MySqlConnection connection = Database.OpenConnection();

            for (int i = 0; i < arr.Count; i++)
            {
                ArrayList row = (ArrayList)arr[i];
                string query = string.Empty;
                if ((bool)row[3])
                {
                    query = $"UPDATE db.automaticsanctions SET LateCount = {row[1].ToString()}, Soort = '{row[2].ToString()}', Status = 1 WHERE automaticsanctions.AutomaticSanctionID ={i + 1};";
                }
                else
                {
                    query = $"UPDATE db.automaticsanctions SET LateCount = {row[1].ToString()}, Soort = '{row[2].ToString()}', Status = 0 WHERE automaticsanctions.AutomaticSanctionID ={i + 1};";
                }

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }

            Database.CloseConnection();

        }




    }
}
