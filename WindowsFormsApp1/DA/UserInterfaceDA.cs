using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DA
{
    public static class UserInterfaceDA
    {
        public static int GetColorTheme()
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = "SELECT Value FROM userinterface WHERE Name = 'KleurTheme'";
            MySqlCommand command = new MySqlCommand(query, connection);
            //command.Parameters.AddWithValue("@Name","KleurTheme");

            command.ExecuteScalar();

            var output = command.ExecuteScalar();
            Database.CloseConnection();
            return Convert.ToInt32(output);
        }

        public static void SetColorTheme(int newNum)
        {
            MySqlConnection connection = Database.OpenConnection();
            string Query = "UPDATE userinterface SET Value = "+newNum.ToString()+" WHERE Name = 'KleurTheme'";
            MySqlCommand command = new MySqlCommand(Query, connection);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }
    }
}
