using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PCSC;
using WindowsFormsApp1.Helper;



namespace WindowsFormsApp1.Helper
{
    public static class DontDestroy
    {
        public static UserInterface UI = new UserInterface();

        public static bool dataLoaded = false;

        public static void promptSave()
        {
            DialogResult dialogResult = MessageBox.Show("Wil je de lokale database ook online opslaan? (dit kan tientalle seconden duren & het programma zal automatisch afsluiten)", "Opslaan?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Backup.SaveOnline();
            }



            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Environment.FailFast(null);
            }

        }

        public static void UpdateUID(string oldUID, string newUID, string tableName)
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = $"UPDATE {tableName} SET CardUID = @newUID WHERE CardUID = @oldUID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@newUID", newUID);
            command.Parameters.AddWithValue("@oldUID", oldUID);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static string GetUID()
        {
            //return "";

            try
            {
                SCardContext ctx = new SCardContext();
                ctx.Establish(SCardScope.System);
                string[] readernames = ctx.GetReaders();
                if (readernames.Length == 1)
                {
                    string readerName = readernames[0];
                    SCardReader RFIDReader = new SCardReader(ctx);
                    SCardError rc;

                    rc = RFIDReader.Connect(readerName, SCardShareMode.Shared, SCardProtocol.Any);
                    if (rc == SCardError.Success)
                    {
                        byte[] ATR;
                        rc = RFIDReader.GetAttrib(SCardAttribute.AtrString, out ATR);
                        if (rc == SCardError.Success && ATR.Length > 2)
                        {
                            string RFIDData = BitConverter.ToString(ATR ?? new byte[] { }).Replace("-", " ");
                            //label1.Text = ("ATR: " + RFIDData);
                        }
                    }

                    //UID
                    byte[] SendBytes = new byte[] { 0xFF, 0xCA, 0x00, 0x00, 0x00 };
                    byte[] RecvBytes = new byte[35];
                    rc = RFIDReader.Transmit(SendBytes, ref RecvBytes);
                    if (rc == SCardError.Success)
                    {
                        string RFIDData = BitConverter.ToString(RecvBytes ?? new byte[] { }).Replace("-", "");

                        if (RFIDData.Length > 10) return RFIDData;
                    }

                    RFIDReader.Disconnect(SCardReaderDisposition.Reset);
                }
            }
            catch
            {
                //Console.WriteLine("Error Occured");
            }

            return null;
        }

        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string GetDate(DateTime dateTime)
        {
            string date = "";
            int currentDay = dateTime.Day;
            int currentMonth = dateTime.Month;
            int currentYear = dateTime.Year;

            if (currentDay < 10)
            {
                date += "0" + currentDay;
            }
            else
            {
                date += currentDay;
            }

            if (currentMonth < 10)
            {
                date += "/0" + currentMonth;
            }
            else
            {
                date += "/" + currentMonth;
            }

            date += "/" + currentYear;

            return date;
        }

        public static string GetTime(DateTime dateTime)
        {
            string Time = "";
            int currentHour = dateTime.Hour;
            int currentMinute = dateTime.Minute;
            if (currentHour < 10)
            {
                Time += "0" + currentHour;
            }
            else
            {
                Time += currentHour;
            }

            if (currentMinute < 10)
            {
                Time += ":0" + currentMinute;
            }
            else
            {
                Time += ":" + currentMinute;
            }

            return Time;
        }

    }
}
