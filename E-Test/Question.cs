using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Question
    {
        string title;
        string[] offers;
        string correct;

        public Question()
        {
            offers = new string[5];
        }

        public Question(string title, string[] offers, string correct)
        {
            this.title = title;
            this.offers = offers;
            this.correct = correct;
        }

        public string Title { get => title; set => title = value; }
        public string[] Offers { get => offers; set => offers = value; }
        public string Correct { get => correct; set => correct = value; }

    }
}
