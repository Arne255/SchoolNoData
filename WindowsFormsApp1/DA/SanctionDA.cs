using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DA
{
    public class SanctionDA
    {
        public static List<Sanction> GetSanctionsBasedOnSearch(string Name, string Surname, string Soort, string ClassName, string ClassDegree, string FromDate, string ToDate, int pullLimit)
        {
            List<Sanction> sanctions = new List<Sanction>();
            MySqlConnection connection = Database.OpenConnection();

            string query = "SELECT * FROM sanctions " +
            "INNER JOIN students ON sanctions.CardUID = students.CardUID " +
            "WHERE ";

            query += "students.Name like '%" + Name + "%'";
            query += " AND Surname like '%" + Surname + "%'";
            query += " AND ClassName like '" + ClassName + "%" + "'";
            query += " AND Soort like '" + Soort + "%" + "'";

            if (ClassDegree == "1")
            {
                query += " AND (LEFT(ClassName, 1) = '1'";
                query += " OR LEFT(ClassName, 1) = '2')";

            }
            else if (ClassDegree == "2")
            {
                query += " AND (LEFT(ClassName, 1) = '3'";
                query += " OR LEFT(ClassName, 1) = '4')";

            }
            else if (ClassDegree == "3")
            {
                query += " AND (LEFT(ClassName, 1) = '5'";
                query += " OR LEFT(ClassName, 1) = '6')";
            }


            query += " AND sanctions.SanctionDatum >= '" + FromDate + "'";

            query += " AND sanctions.SanctionDatum <= '" + ToDate + "'";

            if (query.EndsWith("WHERE ")) // Check For Empty Query!!! If so, resetting...
            {
                query = "SELECT * FROM sanctions " +
                "INNER JOIN students ON sanctions.CardUID = students.CardUID ";
            }

            query += " LIMIT " + pullLimit.ToString() + ";";


            Console.WriteLine(query);

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Sanction sanction = new Sanction();
                sanction.SanctionID = reader.GetInt32("SanctionID");
                sanction.CardUID = reader.GetString("CardUID");
                sanction.Name = reader.GetString("Name");
                sanction.Surname = reader.GetString("Surname");
                sanction.Soort = reader.GetString("Soort");
                sanction.ClassName = reader.GetString("ClassName");
                sanction.SanctionDatum = reader.GetDateTime("SanctionDatum");
                sanction.InitLateID = reader.GetInt32("InitLateID");
                sanctions.Add(sanction);
            }
            Database.CloseConnection();
            return sanctions;
        }



        public static void UploadSanction(Sanction sanction)
        {
            //INSERT INTO Customers(CustomerName, ContactName, Address, City, PostalCode, Country)
            //VALUES('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');

            MySqlConnection connection = Database.OpenConnection();
            string query = "INSERT INTO sanctions(SanctionID, CardUID, Soort, SanctionDatum, InitLateID) VALUES(NULL, @CardUID, @Soort, @SanctionDatum, @InitLateID)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@SanctionID", null);
            command.Parameters.AddWithValue("@CardUID", sanction.CardUID);
            command.Parameters.AddWithValue("@Soort", sanction.Soort);
            command.Parameters.AddWithValue("@SanctionDatum", sanction.SanctionDatum);
            command.Parameters.AddWithValue("@InitLateID", sanction.InitLateID);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static void UpdateSanction(Sanction sanction)
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = "UPDATE sanctions SET Soort = @Soort WHERE SanctionID = @SanctionID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@SanctionID", sanction.SanctionID);
            command.Parameters.AddWithValue("@Soort", sanction.Soort);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }


        public static void DeleteSanctionBasedOnLateInitID(Late late)
        {
            string query = "DELETE FROM sanctions WHERE InitLateID = '" + late.LateID.ToString() + "'";
            MySqlConnection connection = Database.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static void RemoveLate(List<Sanction> sanctions)
        {
            //DELETE FROM Customers WHERE CustomerName='Alfreds Futterkiste';

            bool first = true;
            string query = "DELETE FROM sanctions WHERE ";
            foreach (Sanction sanction in sanctions) //Adding Each ID to the where
            {
                if (first)
                {
                    query += "SanctionID = '" + sanction.SanctionID.ToString() + "'";
                    first = false;
                }
                else
                {
                    query += " OR SanctionID = '" + sanction.SanctionID.ToString() + "'";
                }
            }



            MySqlConnection connection = Database.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static ArrayList GetFilters()
        {
            ArrayList main = new ArrayList();
            main.Add(new List<string>()); //All Distinct Soort
            main.Add(new List<string>()); //All Distinct ClassNames

            MySqlConnection connection_Soort = Database.OpenConnection();
            MySqlConnection connection_ClassName = Database.OpenConnection();
            string query_Soort = "SELECT DISTINCT Soort FROM sanctions";
            string query_ClassName = "SELECT DISTINCT ClassName FROM sanctions INNER JOIN students on sanctions.CardUID = students.CardUID";

            MySqlCommand command_Soort = new MySqlCommand(query_Soort, connection_Soort);
            MySqlDataReader reader_Soort = command_Soort.ExecuteReader();
            while (reader_Soort.Read())
            {
                ((List<string>)main[0]).Add(reader_Soort.GetString("Soort"));
            }


            MySqlCommand command_ClassName = new MySqlCommand(query_ClassName, connection_ClassName);
            MySqlDataReader reader_ClassName = command_ClassName.ExecuteReader();
            while (reader_ClassName.Read())
            {
                ((List<string>)main[1]).Add(reader_ClassName.GetString("ClassName"));
            }

            Database.CloseConnection();
            return main;
        }
    }
}
