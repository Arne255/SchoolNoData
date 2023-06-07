using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Helper
{
    public static class Backup
    {
        public static void SaveOnline()
        {
            ImportAllTablesPublic(ExportAllTablesPrivate());
        }

        public static void LoadFromOnline()
        {
            ImportAllTablesPrivate(ExportAllTablesPublic());
        }

        private static DataSet ExportAllTablesPublic()
        {
            using (MySqlConnection conn = OpenConnectionPublic())
            {
                DataSet ds = new DataSet();
                DataTable schemaTable = conn.GetSchema("Tables");

                foreach (DataRow row in schemaTable.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    string query = $"SELECT * FROM {tableName}";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.Fill(ds, tableName);
                    }
                }
                return ds;
            }
        }

        private static DataSet ExportAllTablesPrivate()
        {
            using (MySqlConnection conn = OpenConnectionPrivate())
            {
                DataSet ds = new DataSet();
                DataTable schemaTable = conn.GetSchema("Tables");

                foreach (DataRow row in schemaTable.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    string query = $"SELECT * FROM {tableName}";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.Fill(ds, tableName);
                    }
                }
                return ds;
            }
        }

        private static void ImportAllTablesPublic(DataSet dataSet)
        {
            using (MySqlConnection conn = OpenConnectionPublic())
            {
                foreach (DataTable table in dataSet.Tables)
                {
                    string tableName = table.TableName;

                    // Truncate the table before importing
                    string truncateQuery = $"TRUNCATE TABLE {tableName}";
                    using (MySqlCommand truncateCmd = new MySqlCommand(truncateQuery, conn))
                    {
                        truncateCmd.ExecuteNonQuery();
                    }

                    // Insert the data into the table
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            StringBuilder columnNames = new StringBuilder();
                            StringBuilder values = new StringBuilder();

                            foreach (DataColumn column in table.Columns)
                            {
                                columnNames.Append($"{column.ColumnName}, ");
                                values.Append($"@{column.ColumnName}, ");
                            }

                            // Remove the trailing commas
                            columnNames.Length -= 2;
                            values.Length -= 2;

                            string insertQuery = $"INSERT INTO {tableName} ({columnNames}) VALUES ({values})";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Transaction = transaction;

                                foreach (DataColumn column in table.Columns)
                                {
                                    insertCmd.Parameters.AddWithValue($"@{column.ColumnName}", row[column]);
                                }

                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                }
            }
        }

        private static void ImportAllTablesPrivate(DataSet dataSet)
        {
            using (MySqlConnection conn = OpenConnectionPrivate())
            {
                foreach (DataTable table in dataSet.Tables)
                {
                    string tableName = table.TableName;

                    // Truncate the table before importing
                    string truncateQuery = $"TRUNCATE TABLE {tableName}";
                    using (MySqlCommand truncateCmd = new MySqlCommand(truncateQuery, conn))
                    {
                        truncateCmd.ExecuteNonQuery();
                    }

                    // Insert the data into the table
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            StringBuilder columnNames = new StringBuilder();
                            StringBuilder values = new StringBuilder();

                            foreach (DataColumn column in table.Columns)
                            {
                                columnNames.Append($"{column.ColumnName}, ");
                                values.Append($"@{column.ColumnName}, ");
                            }

                            // Remove the trailing commas
                            columnNames.Length -= 2;
                            values.Length -= 2;

                            string insertQuery = $"INSERT INTO {tableName} ({columnNames}) VALUES ({values})";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Transaction = transaction;

                                foreach (DataColumn column in table.Columns)
                                {
                                    insertCmd.Parameters.AddWithValue($"@{column.ColumnName}", row[column]);
                                }

                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                }
            }
        }

        private static MySqlConnection OpenConnectionPrivate()
        {
            MySqlConnectionStringBuilder connectionStr = CreateConnectionStr(false);
            MySqlConnection conn = new MySqlConnection(connectionStr.ConnectionString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        private static MySqlConnection OpenConnectionPublic()
        {
            MySqlConnectionStringBuilder connectionStr = CreateConnectionStr(true);
            MySqlConnection conn = new MySqlConnection(connectionStr.ConnectionString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        

        /// <summary>
        /// Creates a connection string
        /// </summary>
        private static MySqlConnectionStringBuilder CreateConnectionStr(bool isPublic)
        {
            if (isPublic)
            {
                MySqlConnectionStringBuilder connectionStr = new MySqlConnectionStringBuilder
                {
                    //Online Fast
                    //Online Fast
                    //Online Fast
                    //
                    Server = "*********",
                    Database = "*******",
                    UserID = "*******",
                    Password = "********",
                    ConnectionTimeout = 60,
                    Port = 3306
                };

                return connectionStr;

            }
            else
            {
                MySqlConnectionStringBuilder connectionStr = new MySqlConnectionStringBuilder
                {
                    //Local
                    //Local
                    //Local
                    //
                    Server = "localhost",
                    Database = "db",
                    UserID = "root",
                    Password = "usbw",
                    ConnectionTimeout = 60,
                    Port = 3307
                };

                return connectionStr;

            }

        }




        /// <summary>
        /// Closes the connection to the database
        /// </summary>
        private static void CloseConnection(bool isPublic)
        {
            MySqlConnectionStringBuilder connectionStr = CreateConnectionStr(isPublic);

            MySqlConnection conn = new MySqlConnection(connectionStr.ConnectionString);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
