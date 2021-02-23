using System;
using System.Collections.Generic;
using System.Text;

namespace ETestUI
{
    public class Etest
    {
        private List<Question> questions = new List<Question>();
        int count = 0;
        int numberOfQuestions;
        public int Points { get; set; } = 0;

        public Etest(int numberOfQuestions)
        {
            this.numberOfQuestions = numberOfQuestions;
        }

        public Question Load()
        {
            return questions[Count];
        }
        public Question Next(string choose)
        {
            if(choose == questions[Count].Correct)
            {
                Points++;
                questions[Count].Point = true;
            }
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
        public int NumberOfQuestions { get => NumberOfQuestions1; set => NumberOfQuestions1 = value;}
        public int Count { get => count; set => count = value; }
        public int NumberOfQuestions1 { get => numberOfQuestions; set => numberOfQuestions = value; }

        int[] random(int number)
        {
            List<int> a = new List<int> { };
            Random r = new Random();
            for (int i = 0; i < NumberOfQuestions1; i++)
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
