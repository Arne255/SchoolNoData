using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;
using System.Drawing;
using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Model;
using Org.BouncyCastle.Utilities.Collections;
using static NPOI.HSSF.Util.HSSFColor;


namespace WindowsFormsApp1.DA
{
    public static class AccountDA
    {
        //Changing To Models
        //Changing To Models
        //Changing To Models
        //Changing To Models
        public static int ValidateAccount(Account account)
        {

            MySqlConnection connection = Database.OpenConnection();
            string query = "SELECT Count(AccountID), isAdmin FROM accounts WHERE Username = BINARY @Username AND Hash = BINARY @Hash AND IsEnabled = 1";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", account.Username);
            command.Parameters.AddWithValue("@Hash", account.Hash);

            MySqlDataReader reader = command.ExecuteReader();
            int result = 0;
            while (reader.Read())
            {
                if (reader.GetInt32("Count(AccountID)") == 1)
                {
                    if (reader.GetBoolean("isAdmin"))
                    {
                        result++;
                    }
                }
                else
                {
                    result--;
                }
            }
            Database.CloseConnection();
            return result; //-1 = no account | 0 = normal account | 1 = admin account
        }

        public static int changeEnabledValue(Account account, bool newChange)
        {
            //UPDATE table_name
            //SET column1 = value1, column2 = value2, ...
            //WHERE condition;

            MySqlConnection connection = Database.OpenConnection();
            string query = "UPDATE accounts SET isEnabled = @isEnabled WHERE Username = @Username";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@IsEnabled", newChange);
            command.Parameters.AddWithValue("@Username", account.Username);
            command.ExecuteNonQuery();
            return 0;
        }

        public static int changeAdminValue(Account account, bool newChange)
        {
            //UPDATE table_name
            //SET column1 = value1, column2 = value2, ...
            //WHERE condition;

            MySqlConnection connection = Database.OpenConnection();
            string query = "UPDATE accounts SET isAdmin = @IsAdmin WHERE Username = @Username";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@isAdmin", newChange);
            command.Parameters.AddWithValue("@Username", account.Username);
            command.ExecuteNonQuery();
            return 0;
        }

        public static void RemoveAccount(Account account)
        {
            //DELETE FROM Customers WHERE CustomerName='Alfreds Futterkiste';

            //REWRITE BASED ON ARRAY :DDDDDDDDDDDDDD

            MySqlConnection connection = Database.OpenConnection();
            string query = "DELETE FROM accounts WHERE Username = @Username";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", account.Username);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            string query = "SELECT * FROM accounts";


            MySqlConnection connection = Database.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Account acc = new Account(
                    reader.GetInt32("AccountID"),
                    reader.GetString("Username"),
                    reader.GetString("Hash"),
                    reader.GetBoolean("isAdmin"),
                    reader.GetBoolean("isEnabled")
                );

                accounts.Add(acc);
            }
            Database.CloseConnection();
            return accounts;
        }

        public static int AddAccount(Account account) //if this returns 1 theres an error
        {
            try
            {
                MySqlConnection connection = Database.OpenConnection();
                string query = "INSERT INTO accounts(Username, Hash) VALUES(@Username, @Hash)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", account.Username);
                command.Parameters.AddWithValue("@Hash", account.Hash);
                command.ExecuteNonQuery();
                Database.CloseConnection();
                return 0;
            }
            catch
            {
                return 1;
            }
        }

        public static Image GetLogo()
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = "SELECT Value FROM userinterface WHERE Name = @Logo";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Logo", "Logo");
            String data = Convert.ToString(command.ExecuteScalar());

            Image img = base64ToImg(data);
            return img;
        }

        public static bool UploadImage(string filePath)
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = "UPDATE userinterface SET value = @Value WHERE Name = @Logo";
            //UPDATE table_name
            //SET column1 = value1, column2 = value2, ...
            //WHERE condition;
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Value", imgToBase64(filePath));
            command.Parameters.AddWithValue("@Logo", "Logo");
            var data = command.ExecuteScalar();
            Database.CloseConnection();
            Console.WriteLine(data);

            return true;
        }

        private static string imgToBase64(string filePath)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(filePath);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);

            return base64ImageRepresentation;
        }

        private static Image base64ToImg(string base64)
        {
            try
            {
                return Image.FromStream(new MemoryStream(Convert.FromBase64String(base64)));
            }
            catch
            {
                return Image.FromFile("../../Resources/logo.png");
            }
        }
    }
}
