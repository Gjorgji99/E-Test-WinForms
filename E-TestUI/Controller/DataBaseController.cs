using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETestUI.Controller
{
    class DataBaseController
    {
        private string ConectionString;

        public static string ConnectionString { get; private set; }

        public static List<Question> loadQuestions()
        {
            string language;
            var path = Path.Combine(Environment.CurrentDirectory, "dbEtest.db");
            ConnectionString = "Data Source = " + path + ";";
            if (Properties.Settings.Default.Language == "mk-MK")
            {
                language = "MK";
            }
            else
            {
                language = "EN";
            }
            string stringSql = "SELECT * FROM Questions" + language;
            List<Question> temp = new List<Question>();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(stringSql, connection);
                using(SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        string title = (string)sqlReader["title"];
                        string offer1 = (string)sqlReader["offer1"];
                        string offer2 = (string)sqlReader["offer2"];
                        string offer3 = (string)sqlReader["offer3"];
                        string offer4 = (string)sqlReader["offer4"];
                        string correct = (string)sqlReader["correct"];
                        temp.Add(new Question(title,offer1,offer2,offer3,offer4,correct));

                    }
                }
                return temp;
            }        
        }
        public static void addQuestion(Question q)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "dbEtest.db");
            ConnectionString = "Data Source = " + path + ";";
            string language;
            if(Properties.Settings.Default.Language == "mk-MK")
            {
                language = "MK";
            }else
            {
                language = "EN";
            }
            string queryString = "INSERT INTO Questions"+language+"(title, offer1, offer2, offer3, offer4, correct)" +
                " values(@title,@offer1,@offer2,@offer3,@offer4,@correct); " ;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(queryString, connection);
                command.Parameters.AddWithValue("@title", q.Title);
                command.Parameters.AddWithValue("@offer1", q.Offer1);
                command.Parameters.AddWithValue("@offer2", q.Offer2);
                command.Parameters.AddWithValue("@offer3", q.Offer3);
                command.Parameters.AddWithValue("@offer4", q.Offer4);
                command.Parameters.AddWithValue("@correct", q.Correct);
                command.ExecuteScalar();
            }
        }
        public static void deleteQuestion(Question q)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "dbEtest.db");
            ConnectionString = "Data Source = " + path + ";";
            string language;
            if (Properties.Settings.Default.Language == "mk-MK")
            {
                language = "MK";
            }
            else
            {
                language = "EN";
            }
            string stringSql = "DELETE FROM Questions"+language+" WHERE title=@title";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@title", q.Title);
                command.ExecuteNonQuery();
            }
        }
    }
}
