using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Helper;


namespace WindowsFormsApp1.DA
{
    public static class StudentDA
    {
        public static void TruncateTable()
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = "TRUNCATE TABLE students";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static void UploadStudent(Student student)
        {
            MySqlConnection connection = Database.OpenConnection();
            string query = "INSERT INTO students(CardUID, Name, Surname, ClassName, TownshipNameOne, TownshipNameTwo) VALUES(@CardUID, @Name, @Surname, @ClassName, @TownshipNameOne, @TownshipNameTwo)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@CardUID", student.CardUID);
            command.Parameters.AddWithValue("@Name", student.Name);
            command.Parameters.AddWithValue("@Surname", student.Surname);
            command.Parameters.AddWithValue("@ClassName", student.ClassName);
            command.Parameters.AddWithValue("@TownshipNameOne", student.TownshipNameOne);
            command.Parameters.AddWithValue("@TownshipNameTwo", student.TownshipNameTwo);
            command.ExecuteScalar();
            Database.CloseConnection();
        }
        public static void UpdateStudent(string oldUID, Student student)
        {
            MySqlConnection connection = Database.OpenConnection(); // Assumes there is a method called OpenConnection() in the Database class that returns a MySqlConnection object
            string query = "UPDATE students SET Name=@Name, Surname=@Surname, ClassName=@ClassName, TownshipNameOne=@TownshipNameOne, TownshipNameTwo=@TownshipNameTwo, CardUID=@NewUID WHERE CardUID=@OldUID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", student.Name);
            command.Parameters.AddWithValue("@Surname", student.Surname);
            command.Parameters.AddWithValue("@ClassName", student.ClassName);
            command.Parameters.AddWithValue("@TownshipNameOne", student.TownshipNameOne);
            command.Parameters.AddWithValue("@TownshipNameTwo", student.TownshipNameTwo);
            command.Parameters.AddWithValue("@NewUID", student.CardUID);
            command.Parameters.AddWithValue("@OldUID", oldUID);
            command.ExecuteNonQuery(); // Use ExecuteNonQuery() to execute a query that doesn't return any data
            Database.CloseConnection(); // Assumes there is a method called CloseConnection() in the Database class that closes the MySqlConnection object
        }

        public static void RemoveStudent(List<Student> students)
        {
            //DELETE FROM Customers WHERE CustomerName='Alfreds Futterkiste';
            string query = "DELETE FROM students WHERE ";
            bool first = true;
            foreach (Student student in students) //Adding Each ID to the where
            {
                if (first)
                {
                    query += "CardUID = '" + student.CardUID + "'";
                    first = false;
                }
                else
                {
                    query += " OR CardUID = '" + student.CardUID + "'";
                }
            }

            MySqlConnection connection = Database.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static List<Student> GetStudentsBasedOnSearch(string Name, string Surname, string ClassName, string ClassDegree, string TownshipNameOne, string TownshipNameTwo, int pullLimit)
        {
            List<Student> students = new List<Student>();
            MySqlConnection connection = Database.OpenConnection();
            string query = "SELECT * FROM students " +
            "WHERE ";

            string WhereStatement = "";

            WhereStatement += "students.Name like '%" + Name + "%'";
            WhereStatement += " AND Surname like '%" + Surname + "%'";
            WhereStatement += " AND ClassName like '" + ClassName + "%" + "'";
            WhereStatement += " AND TownshipNameOne like '" + TownshipNameOne + "%" + "'";
            WhereStatement += " AND TownshipNameTwo like '" + TownshipNameTwo + "%" + "'";

            query += WhereStatement;

            if (ClassDegree == "1")
            {
                query += " AND LEFT(ClassName, 1) = '1'";

            }
            else if (ClassDegree == "2")
            {
                query += " AND LEFT(ClassName, 1) = '3'";

            }
            else if (ClassDegree == "3")
            {
                query += " AND LEFT(ClassName, 1) = '5'";
            }

            query += " OR " + WhereStatement;


            if (ClassDegree == "1")
            {
                query += " AND LEFT(ClassName, 1) = '2'";

            }
            else if (ClassDegree == "2")
            {
                query += " AND LEFT(ClassName, 1) = '4'";

            }
            else if (ClassDegree == "3")
            {
                query += " AND LEFT(ClassName, 1) = '6'";
            }


            if (ClassDegree == "3")
            {
                query += " OR " + WhereStatement;
                query += " AND LEFT(ClassName, 1) = '7'";
            }

            query += " LIMIT " + pullLimit.ToString() + ";";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    Student student = new Student();
                    student.CardUID = reader.GetString("CardUID");
                    student.Name = reader.GetString("Name");
                    student.Surname = reader.GetString("Surname");
                    student.ClassName = reader.GetString("ClassName");
                    student.TownshipNameOne = reader.GetString("TownshipNameOne");
                    student.TownshipNameTwo = reader.GetString("TownshipNameTwo");


                    students.Add(student);
                }
                catch
                {
                    //RemoveStudent(CardUID);
                }

            }
            Database.CloseConnection();
            return students;
        }

        public static ArrayList GetFilters()
        {
            ArrayList main = new ArrayList();
            main.Add(new List<string>()); //All Distinct ClassNames
            main.Add(new List<string>()); //All Distinct TownshipsOne
            main.Add(new List<string>()); //All Distinct TownshipsTwo

            MySqlConnection connection_ClassName = Database.OpenConnection();
            MySqlConnection connection_ClassTownshipNameOne = Database.OpenConnection();
            MySqlConnection connection_ClassTownshipNameTwo = Database.OpenConnection();
            string query_ClassName = "SELECT DISTINCT ClassName FROM students";
            string query_TownshipNameOne = "SELECT DISTINCT TownshipNameOne FROM students";
            string query_TownshipNameTwo = "SELECT DISTINCT TownshipNameTwo FROM students";

            MySqlCommand command_ClassName = new MySqlCommand(query_ClassName, connection_ClassName);
            MySqlDataReader reader_ClassName = command_ClassName.ExecuteReader();
            while (reader_ClassName.Read())
            {
                ((List<string>)main[0]).Add(reader_ClassName.GetString("ClassName"));
            }

            MySqlCommand command_TownshipNameOne = new MySqlCommand(query_TownshipNameOne, connection_ClassTownshipNameOne);
            MySqlDataReader reader_TownshipNameOne = command_TownshipNameOne.ExecuteReader();
            while (reader_TownshipNameOne.Read())
            {
                ((List<string>)main[1]).Add(reader_TownshipNameOne.GetString("TownshipNameOne"));
            }

            MySqlCommand command_TownshipNameTwo = new MySqlCommand(query_TownshipNameTwo, connection_ClassTownshipNameTwo);
            MySqlDataReader reader_TownshipNameTwo = command_TownshipNameTwo.ExecuteReader();
            while (reader_TownshipNameTwo.Read())
            {
                ((List<string>)main[2]).Add(reader_TownshipNameTwo.GetString("TownshipNameTwo"));
            }
                

            Database.CloseConnection();
            return main;
        }

        public static List<Late> GetLatesFromStudent(Student student)
        {
            List<Late> lates = new List<Late>();

            Console.WriteLine("Opening database connection...");
            MySqlConnection connection = Database.OpenConnection();
            Console.WriteLine("Database connection opened.");

            string query = "SELECT * FROM students " +
                "INNER JOIN lates ON students.CardUID = lates.CardUID " +
                "INNER JOIN reasons ON lates.ReasonID = reasons.ReasonID " +
                "WHERE students.CardUID = '" + student.CardUID + "'";



            MySqlCommand command = new MySqlCommand(query, connection);
            //command.Parameters.AddWithValue("@cardUID", student.CardUID);

            Console.WriteLine("Executing SQL query...");
            MySqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("SQL query executed.");

            

            while (reader.Read())
            {
                Late late = new Late();
                late.LateID = reader.GetInt32("LateID");
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

            Console.WriteLine(lates.Count);
            reader.Close();

            Database.CloseConnection();


            return lates;
        }



        //DON4T Change
        //DON4T Change
        //DON4T Change
        //DON4T Change
        //
        //
        //   |
        //   |
        //  \ /

        public static Student GetStudentFromCardUID(string CardUID)
        {
            MySqlConnection connection = Database.OpenConnection();
            //string query = "SELECT Name, Surname, ClassName, TownshipNameOne, TownshipNameTwo FROM students " +
            //    "WHERE CardUID = '" + CardUID + "'";

            string query = "SELECT * FROM students WHERE CardUID LIKE '" + CardUID + "%' LIMIT 1";
            Console.WriteLine(query);

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            Student student = null;
            while (reader.Read())
            {
                try
                {
                    student = new Student();
                    student.CardUID = reader.GetString("CardUID"); 
                    student.Name = reader.GetString("Name");
                    student.Surname = reader.GetString("Surname");
                    student.ClassName = reader.GetString("ClassName");
                    student.TownshipNameOne = reader.GetString("TownshipNameOne");
                    student.TownshipNameTwo = reader.GetString("TownshipNameTwo");
                }
                catch
                {
                    //RemoveStudent(CardUID);
                }

            }
            Database.CloseConnection();
            return student;
        }


        //Mass Upload

        //INSERT INTO
        //projects(name, start_date, end_date)
        //VALUES
        //    ('AI for Marketing','2019-08-01','2019-12-31'),
        //    ('ML for Sales','2019-05-15','2019-11-20');


        public static bool MassUpload(List<List<string>> Data)
        {
            try
            {

                List<Student> students = new List<Student>();
                MySqlConnection connection = Database.OpenConnection();
                string query = "INSERT INTO students(CardUID, Name, Surname, ClassName, TownshipNameOne, TownshipNameTwo) " +
                "VALUES ";

                int myName = Convert.ToInt32(Data[0].Count);
                for (int i = 0; i < myName; i++)
                {
                    string CardUID = Data[0][i];
                    string Name = Data[1][i];
                    string Surname = Data[2][i];
                    string ClassName = Data[3][i];
                    string TownshipNameOne = Data[4][i];
                    string TownshipNameTwo = Data[5][i];

                    if (i == myName - 1)
                    {
                        query += "(\"" + CardUID + "\",\"" + Name + "\",\"" + Surname + "\",\"" + ClassName + "\",\"" + TownshipNameOne + "\",\"" + TownshipNameTwo + "\");";
                    }
                    else
                    {
                        query += "(\"" + CardUID + "\",\"" + Name + "\",\"" + Surname + "\",\"" + ClassName + "\",\"" + TownshipNameOne + "\",\"" + TownshipNameTwo + "\"),";
                    }
                }



                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
