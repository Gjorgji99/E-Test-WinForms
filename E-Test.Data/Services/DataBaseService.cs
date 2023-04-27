using Etest.Data.Models;
using System.Data.SQLite;

namespace Etest.Data.Services
{
    public class DataBaseService
    {


        private static string? ConnectionString;
        public static List<Question> loadQuestionsByLanguage(string language)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "dbEtest.db");
            ConnectionString = "Data Source = " + path + ";";
            string stringSql = "SELECT * FROM questions WHERE language = @language";
            List<Question> temp = new List<Question>();
            using (SQLiteConnection connection = new(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new(stringSql, connection);
                command.Parameters.AddWithValue("@language", language);
                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        string title = (string)sqlReader["title"];
                        string offer1 = (string)sqlReader["offer0"];
                        string offer2 = (string)sqlReader["offer1"];
                        string offer3 = (string)sqlReader["offer2"];
                        string offer4 = (string)sqlReader["offer3"];
                        string correct = sqlReader["correct"].ToString()!;
                        temp.Add(new Question(title, offer1, offer2, offer3, offer4, correct, language));

                    }
                }
                return temp;
            }
        }

        public static List<Question> loadQuestionsByLanguageAndNoQ(string language, string numberOfQuestions)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "dbEtest.db");
            ConnectionString = "Data Source = " + path + ";";
            string stringSql = "SELECT * FROM questions WHERE language = @language ORDER BY RANDOM() LIMIT @numberOfQuestions;";
            if (numberOfQuestions == "0")
                stringSql = "SELECT * FROM questions WHERE language = @language";
            List<Question> temp = new List<Question>();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@language", language);
                command.Parameters.AddWithValue("@numberOfQuestions", numberOfQuestions);
                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        string title = (string)sqlReader["title"];
                        string offer1 = (string)sqlReader["offer0"];
                        string offer2 = (string)sqlReader["offer1"];
                        string offer3 = (string)sqlReader["offer2"];
                        string offer4 = (string)sqlReader["offer3"];
                        string correct = (string)sqlReader["correct"];
                        temp.Add(new Question(title, offer1, offer2, offer3, offer4, correct, language));

                    }
                }
                return temp;
            }
        }
        public static void addQuestion(Question q, string language)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "dbEtest.db");
            ConnectionString = "Data Source = " + path + ";";
            string queryString = "INSERT INTO questions(title, offer1, offer2, offer3, offer4, correct, language)" +
                " values(@title,@offer1,@offer2,@offer3,@offer4,@correct,@language); ";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(queryString, connection);
                command.Parameters.AddWithValue("@title", q.Title);
                command.Parameters.AddWithValue("@offer0", q.Offer0);
                command.Parameters.AddWithValue("@offer1", q.Offer1);
                command.Parameters.AddWithValue("@offer2", q.Offer2);
                command.Parameters.AddWithValue("@offer3", q.Offer3);
                command.Parameters.AddWithValue("@correct", q.Correct);
                command.Parameters.AddWithValue("@language", language);
                command.ExecuteScalar();
            }
        }
        public static void deleteQuestion(Question q)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "dbEtest.db");
            ConnectionString = "Data Source = " + path + ";";
            string stringSql = "DELETE FROM Questions WHERE title=@title";
            using (SQLiteConnection connection = new(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@title", q.Title);
                command.ExecuteNonQuery();
            }
        }
    }
}
