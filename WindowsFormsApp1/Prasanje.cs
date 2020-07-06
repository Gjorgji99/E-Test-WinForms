using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Prasanje
    {
        string naslov;
        string[] ponudi;
        string tocen;

        public Prasanje()
        {
            ponudi = new string[5];
        }

        public Prasanje(string naslov, string[] ponudi, string tocen)
        {
            this.naslov = naslov;
            this.ponudi = ponudi;
            this.tocen = tocen;
        }

        public string Naslov { get => naslov; set => naslov = value; }
        public string[] Ponudi { get => ponudi; set => ponudi = value; }
        public string Tocen { get => tocen; set => tocen = value; }

    }
}
