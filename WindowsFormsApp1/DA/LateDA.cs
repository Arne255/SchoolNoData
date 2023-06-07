using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Helper;

using System.Collections;

namespace WindowsFormsApp1.DA
{
    public static class LateDA
    {
        public static List<Late> GetLatesBasedOnSearch(string Name, string Surname, string ClassName, string ClassDegree, string TownshipNameOne, string TownshipNameTwo, string ReasonText, string isCustom, string isValid, string FromDate, string ToDate, int pullLimit)
        {
            List<Late> lates = new List<Late>();

            MySqlConnection connection = Database.OpenConnection();
            string query = "SELECT * FROM lates " +
            "INNER JOIN students ON lates.CardUID = students.CardUID " +
            "INNER JOIN reasons ON lates.ReasonID = reasons.ReasonID " +
            "WHERE ";

            query += "students.Name like '%" + Name + "%'";
            query += " AND Surname like '%" + Surname + "%'";
            query += " AND ClassName like '" + ClassName + "%" + "'";

            if (ClassDegree == "1")
            {
                query += " AND LEFT(ClassName, 1) = '1'";
                query += " OR LEFT(ClassName, 1) = '2'";

            }
            else if (ClassDegree == "2")
            {
                query += " AND LEFT(ClassName, 1) = '3'";
                query += " OR LEFT(ClassName, 1) = '4'";

            }
            else if (ClassDegree == "3")
            {
                query += " AND LEFT(ClassName, 1) = '5'";
                query += " OR LEFT(ClassName, 1) = '6'";
            }


            query += " AND TownshipNameOne like '" + TownshipNameOne + "%" + "'";
            query += " AND TownshipNameTwo like '" + TownshipNameTwo + "%" + "'";

            if (isCustom != null)
            {
                if (isCustom == "True")
                {
                    query += " AND reasons.isCustom = '" + "1" + "'";
                }
                else
                {
                    query += " AND reasons.isCustom = '" + "0" + "'";
                }
            }

            if (isValid != null)
            {
                if (isValid == "Ja")
                {
                    query += " AND reasons.isValid = '" + "1" + "'";
                }
                else
                {
                    query += " AND reasons.isValid = '" + "0" + "'";
                }
            }

            query += " AND lates.LateDate >= '" + FromDate + "'";

            query += " AND lates.LateDate <= '" + ToDate + "'";



            if (query.EndsWith("WHERE ")) // Check For Empty Query!!! If so, resetting...
            {
                query = "SELECT * FROM lates " +
                            "INNER JOIN students ON lates.CardUID = students.CardUID " +
                            "INNER JOIN reasons ON lates.ReasonID = reasons.ReasonID ";
            }

            query += " LIMIT " + pullLimit.ToString() + ";";

            Console.WriteLine(query);
            Console.WriteLine(query);

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Late late = new Late();
                late.LateID = reader.GetInt32("lateID");
                late.CardUID = reader.GetString("CardUID");
                late.Name = reader.GetString("Name");
                late.Surname = reader.GetString("Surname");
                late.ClassName = reader.GetString("ClassName");
                late.TownshipNameOne = reader.GetString("TownshipNameOne");
                late.TownshipNameTwo = reader.GetString("TownshipNameTwo");
                late.ReasonID = reader.GetInt32("ReasonID");
                late.ReasonText = reader.GetString("ReasonText");
                late.ReasonIsCustom = reader.GetBoolean("isCustom");
                late.ReasonIsValid = reader.GetBoolean("isValid");
                late.LateDate = reader.GetDateTime("LateDate");

                lates.Add(late);
            }
            Database.CloseConnection();
            return lates;
        }

        public static void UpdateLateReasonID(Late late)
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = "UPDATE lates SET ReasonID = @newReasonID WHERE LateID = @lateID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@newReasonID", late.ReasonID);
            command.Parameters.AddWithValue("@lateID", late.LateID);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }


        public static void UploadLate(Late late)
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = "INSERT INTO lates(CardUID, ReasonID, LateDate) VALUES(@CardUID, @ReasonID, @LateDate)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@CardUID", late.CardUID);
            command.Parameters.AddWithValue("@ReasonID", late.ReasonID);
            command.Parameters.AddWithValue("@LateDate", late.LateDate);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static ArrayList GetLatestLateID(Late late)
        {
            ArrayList result = new ArrayList();
            result.Add(false);

            MySqlConnection connection = Database.OpenConnection();
            string query = "SELECT LateID FROM lates WHERE CardUID=@CardUID ORDER BY LateDate DESC LIMIT 1";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@CardUID", late.CardUID);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int lateID = reader.GetInt32("LateID");
                result[0] = true;
                result.Add(lateID);
            }

            reader.Close();
            Database.CloseConnection();

            return result;
        }

        public static void RemoveLate(List<Late> lates)
        {
            //DELETE FROM Customers WHERE CustomerName='Alfreds Futterkiste';

            bool first = true;
            string query = "DELETE FROM lates WHERE ";
            foreach (Late late in lates) //Adding Each ID to the where
            {
                if (first)
                {
                    query += "LateID = '" + late.LateID.ToString() + "'";
                    first = false;
                }
                else
                {
                    query += " OR LateID = '" + late.LateID.ToString() + "'";
                }
            }



            MySqlConnection connection = Database.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }
    }
}
