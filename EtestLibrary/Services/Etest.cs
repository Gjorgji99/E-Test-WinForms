using EtestLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtestLibrary.Services
{
    public class Etest
    {
        private List<Question> questions = new List<Question>();
        int count = 0;
        int numberOfQuestions;
        public int Points { get; set; } = 0;
        public Etest(string numberOfQuestions,string language)
        {
            this.NumberOfQuestions = Int32.Parse(numberOfQuestions);
            List<Question> temp = DataBaseController.loadQuestions(language);
            int[] numbers = random(temp.Count);
            for (int i = 0; i < this.numberOfQuestions; i++)
            {
                questions.Add(temp[numbers[i]]);
            }
        }
        public Question Load => questions[Count];
        public void checkQuestion(string choose)
        {
            if (choose == questions[Count].Correct)
            {
                Points++;
                questions[Count].Point = true;
            }
        }
        public Question Next(string choose)
        {
            checkQuestion(choose);
            return questions[++Count];
        }
        public Question Back()
        {
            if (questions[--Count].Point)
            {
                questions[Count].Point = false;
                Points--;
            }
            return questions[Count];
        }

        public int Count { get => count; set => count = value; }
        public int NumberOfQuestions { get => numberOfQuestions; set => numberOfQuestions = value; }

        int[] random(int number)
        {
            List<int> a = new List<int> { };
            Random r = new Random();
            for (int i = 0; i < numberOfQuestions; i++)
            {
                int n;
                do n = r.Next(0, number);
                while (a.Contains(n));
                a.Add(n);
            }
            return a.ToArray();
        }
    }
}
