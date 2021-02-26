using System;
using System.Collections.Generic;
using System.Text;

namespace EtestLibrary.Models
{
    public class Question
    {

        string title;
        string offer1;
        string offer2;
        string offer3;
        string offer4;
        string correct;
        bool point;
        public Question()
        {
        }

        public Question(string title, string offer1, string offer2, string offer3, string offer4, string correct)
        {
            this.title = title;
            this.Offer1 = offer1;
            this.Offer2 = offer2;
            this.Offer3 = offer3;
            this.Offer4 = offer4;
            this.correct = correct;
            point = false;
        }

        public string Title { get => title; set => title = value; }
        public string Correct { get => correct; set => correct = value; }
        public string Offer1 { get => offer1; set => offer1 = value; }
        public string Offer2 { get => offer2; set => offer2 = value; }
        public string Offer3 { get => offer3; set => offer3 = value; }
        public string Offer4 { get => offer4; set => offer4 = value; }
        public bool Point { get => point; set => point = value; }

        public override string ToString()
        {
            return title + ", " + offer1 + ", " + offer2 + ", " + offer3 + ", " + offer4 + ", " + correct;
        }
    }
}


