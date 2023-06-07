using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DA
{
    public static class LateCounterDA
    {
        public static void ResetCountFromStudent(Student student)
        {
            string studentCardUID = student.CardUID;
            MySqlConnection connection = Database.OpenConnection();
            string query = "UPDATE latecounter SET Count = 0 WHERE CardUID = @studentCardUID";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@studentCardUID", studentCardUID);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }


        public static ArrayList Find(Student student)
        {
            string cardUID = student.CardUID;
            ArrayList result = new ArrayList();

            MySqlConnection connection = Database.OpenConnection();
            string query = "SELECT CardUID, Count FROM latecounter " +
            "WHERE ";

            query += "latecounter.cardUID = '" + cardUID.ToString() + " '";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(true);
                result.Add(reader.GetString("CardUID"));
                result.Add(reader.GetInt32("Count"));
            }
            Database.CloseConnection();
            if (result.Count == 0)
            {
                result.Add(false);
            }

            return result;
        }

        public static void IncreaseCount(Student student)
        {
            string studentCardUID = student.CardUID;
            MySqlConnection connection = Database.OpenConnection();
            string query = "UPDATE latecounter SET Count = Count + 1 " +
            "WHERE ";

            query += "latecounter.CardUID = '" + studentCardUID + " '";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static void DecreaseCount(Student student)
        {
            string studentCardUID = student.CardUID;
            MySqlConnection connection = Database.OpenConnection();
            string query = "UPDATE latecounter SET Count = Count - 1 " +
            "WHERE ";

            query += "latecounter.CardUID = '" + studentCardUID + " '";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static void CreateCount(Student student)
        {
            string studentCardUID = student.CardUID;
            MySqlConnection connection = Database.OpenConnection();
            string query = "INSERT INTO latecounter (CardUID, Count) VALUES (@studentCardUID, 1)";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@studentCardUID", studentCardUID);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }


        public static void ResetCount(int countThreshold)
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = "DELETE FROM latecounter WHERE Count <= @countThreshold";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@countThreshold", countThreshold);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

    }
}
