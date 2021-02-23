using LiteDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETestUI.Controller
{
    class DataBaseController
    {
        public static List<Question> loadQuestions()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "..\\..\\dbEtest.db");
            using (var db = new LiteDatabase(path))
            {
                return db.GetCollection <Question>("QuestionsMK").Query().ToList();
            }        
        }
        public static void addQuestion(Question q)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "..\\..\\dbEtest.db");
            using (var db = new LiteDatabase(path))
            {
                var collection = db.GetCollection<Question>("QuestionsMK");
                collection.Insert(q);     
            }
        }
        public static void deleteQuestion(Question q)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "..\\..\\dbEtest.db");
            using (var db = new LiteDatabase(path))
            {
                var collection = db.GetCollection<Question>("QuestionsMK");
                var delete = collection.Find(x => x.Title == q.Title);
                collection.Delete((BsonValue)delete);
            }
        }
    }
}
