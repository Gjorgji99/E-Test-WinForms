using EtestLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace EtestLibrary.Services
{
    public class Etest
    {
        private Dictionary<Question,Boolean> questions = new Dictionary<Question,Boolean>();
        int count = 0;
        int numberOfQuestions;
        public int Points { get; set; } = 0;
        public Etest(string numberOfQuestions,string language)
        {
            this.NumberOfQuestions = Int32.Parse(numberOfQuestions);
            DataBaseService.loadQuestionsByLanguageAndNoQ(language,numberOfQuestions).ForEach(q => questions.Add(q, false));
        }
        public Question Load => questions.ElementAt(Count).Key;
        public void checkQuestion(string choose)
        {
            if (choose == questions.ElementAt(count).Key.Correct)
            {
                Points++;
                questions[questions.ElementAt(count).Key] = true;
            }
        }
        public Question Next(string choose)
        {
            checkQuestion(choose);
            return questions.ElementAt(++Count).Key;
        }
        public Question Back()
        {
            if (questions[questions.ElementAt(count).Key])
            {
                questions[questions.ElementAt(Count).Key] = false;
                Points--;
            }
            return questions.ElementAt(Count).Key;
        }

        public int Count { get => count; set => count = value; }
        public int NumberOfQuestions { get => numberOfQuestions; set => numberOfQuestions = value; }


    }
}
