using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.DA
{
    public static class ReasonDA
    {

        public static List<Reason> GetReasons()
        {
            List<Reason> Reasons = new List<Reason>();

            MySqlConnection connection = Database.OpenConnection();
            string query = "SELECT * FROM reasons";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Reason reason = new Reason();
                reason.ReasonID = reader.GetInt32("ReasonID");
                reason.ReasonText = reader.GetString("ReasonText");
                reason.IsCustom = reader.GetBoolean("isCustom");
                reason.IsValid = reader.GetBoolean("isValid");


                Reasons.Add(reason);
            }
            Database.CloseConnection();
            return Reasons;
        }

        public static void UploadReason(Reason reason)
        {
            //INSERT INTO Customers(CustomerName, ContactName, Address, City, PostalCode, Country)
            //VALUES('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');

            MySqlConnection connection = Database.OpenConnection();
            string query = "INSERT INTO reasons(ReasonText, isValid, isCustom) VALUES(@ReasonText, @isValid, @isCustom)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReasonText", reason.ReasonText);
            command.Parameters.AddWithValue("@isValid", reason.IsValid);
            command.Parameters.AddWithValue("@isCustom", reason.IsCustom);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static void UpdateReasonCustom(Reason reason)
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = "UPDATE reasons SET isCustom = @isCustom, isValid = @isValid WHERE ReasonID = @ReasonID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@isCustom", reason.IsCustom);
            command.Parameters.AddWithValue("@isValid", reason.IsValid);
            command.Parameters.AddWithValue("@ReasonID", reason.ReasonID);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }


        public static int GetCustomReasonIDByTextAndIsValid(Reason reason)
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = string.Empty;
            if (reason.IsValid)
            {
                query = "SELECT ReasonID FROM reasons where ReasonText = '" + reason.ReasonText + "' AND IsValid = '1'";
            }
            else
            {
                query = "SELECT ReasonID FROM reasons where ReasonText = '" + reason.ReasonText + "' AND IsValid = '0'";
            }

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            int reasonID = -1;
            while (reader.Read())
            {
                reasonID = reader.GetInt32("ReasonID");
            }
            Database.CloseConnection();
            return reasonID;
        }


        public static void RemoveReason(Reason reason)
        {
            //DELETE FROM Customers WHERE CustomerName='Alfreds Futterkiste';

            MySqlConnection connection = Database.OpenConnection();
            string query = "DELETE FROM reasons WHERE ReasonID = @ReasonID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReasonID", reason.ReasonID);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }
    }
}