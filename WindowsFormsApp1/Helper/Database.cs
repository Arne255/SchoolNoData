using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Helper
{
    public static class Database
    {
        /// <summary>
        /// Opens a connection to the database
        /// </summary>
        public static MySqlConnection OpenConnection()
        {
            MySqlConnectionStringBuilder connectionStr = CreateConnectionStr();
            MySqlConnection conn = new MySqlConnection(connectionStr.ConnectionString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        /// <summary>
        /// Closes the connection to the database
        /// </summary>
        public static void CloseConnection()
        {
            MySqlConnectionStringBuilder connectionStr = CreateConnectionStr();

            MySqlConnection conn = new MySqlConnection(connectionStr.ConnectionString);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Creates a connection string
        /// </summary>
        private static MySqlConnectionStringBuilder CreateConnectionStr()
        {
            MySqlConnectionStringBuilder connectionStr = new MySqlConnectionStringBuilder
            {
                //Online Slow
                //Online Slow
                //Online Slow
                //
                //Server = "*********",
                //Database = "*********",
                //UserID = "*********",
                //Password = "*********",
                //ConnectionTimeout = 60,
                //Port = 9103

                //LOCAL
                //LOCAL
                //LOCAL
                //
                Server = "localhost",
                Database = "db",
                UserID = "root",
                Password = "usbw",
                ConnectionTimeout = 60,
                Port = 3307

                //Online Fast
                //Online Fast
                //Online Fast
                //
                //Server = "*********",
                //Database = "*********",
                //UserID = "*********",
                //Password = "*********",
                //ConnectionTimeout = 60,
                //Port = 3306

            };

            return connectionStr;
        }
    }
}
