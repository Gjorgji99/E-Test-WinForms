using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Etest.Data.Models
{
    public class Question
    {
        long id;
        string title;
        string offer0;
        string offer1;
        string offer2;
        string offer3;
        string language;
        string correct;
        public Question(string title, string offer0, string offer1, string offer2, string offer3, string correct, string language)
        {
            this.title = title;
            this.offer0 = offer0;
            this.offer1 = offer1;
            this.offer2 = offer2;
            this.offer3 = offer3;
            this.language = language;
            this.correct = correct;
        }

        public string Title { get => title; set => title = value; }
        public string Correct { get => correct; set => correct = value; }
        
      
        public long Id { get => id; set => id = value; }
        public string Language { get => language; set => language = value; }
        public string Offer0 { get => offer0; set => offer0 = value; }
        public string Offer1 { get => offer1; set => offer1 = value; }
        public string Offer2 { get => offer2; set => offer2 = value; }
        public string Offer3 { get => offer3; set => offer3 = value; }

        public override string ToString()
        {
            return title + ", " + Offer0 + ", " + Offer1 + ", " + Offer2 + ", " + Offer3 + ", " + correct;
        }
    }
}


