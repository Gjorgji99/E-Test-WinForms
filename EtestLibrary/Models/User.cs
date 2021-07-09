using System;
using System.Collections.Generic;
using System.Text;
using EtestLibrary.Services;

namespace EtestLibrary.Models
{
    public class User
    {
        string name;
        public Etest test;

        public User()
        {
        }

        public User(string name,Etest test){
            this.name = name;
            this.Test = test;
        }

        public string Name { get; set; }
        public Etest Test { get ; set ; }
    }
}


