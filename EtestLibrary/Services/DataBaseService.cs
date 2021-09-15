using EtestLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EtestLibrary.Services
{
    public class DataBaseService
    {
 
        public static List<Question> loadQuestions(string language)
        {
            using(QuestionContext db = new QuestionContext()){

                return db.Questions.ToList();
            }

        }
        public static void addQuestion(Question q)
        {
            using (QuestionContext db = new QuestionContext())
            {
                db.Add(q);
                db.SaveChangesAsync();
            }
        }
        public static void deleteQuestion(Question q)
        {
            using (QuestionContext db = new QuestionContext())
            {
                db.Remove(q);
                db.SaveChanges();
            }
        }
    }
}
