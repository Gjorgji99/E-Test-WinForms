using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Testform : Form
    {
        public Testform()
        {
            InitializeComponent();
        }
        private string ime;
        private List<Prasanje> prasanja =  new List<Prasanje> { };
        
        int count = 0;
        int brojnaprasanja;
        int[] randombroevi;
        string[] odgovori;

        public void Brojnaprasanja(int n){
            brojnaprasanja = n;
        }
        public void setIme(string ime)
        {
            this.ime = ime;
        }

        protected void testform_Load(object sender, EventArgs e)
        {
            lname.Text += ime;
            string filePath = (Environment.CurrentDirectory + "\\Prasanja12.txt");
            string[] lines = File.ReadAllLines(filePath);
            string filePath1 = (Environment.CurrentDirectory + "\\brojnaprasanja.txt");
            string[] lines1 = File.ReadAllLines(filePath1);
            brojnaprasanja = Convert.ToInt32(lines1[0]);
            
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                List<string> odgovor = new List<string> {};
                odgovor.Add(parts[1]);
                odgovor.Add(parts[2]);
                odgovor.Add(parts[3]);
                odgovor.Add(parts[4]);
                prasanja.Add(new Prasanje(parts[0], odgovor.ToArray(), parts[5]));
            }
            odgovori = new string[brojnaprasanja];
            randombroevi = random();
            load(randombroevi[count]);
            count++;

        }
        private void load(int i)
        {
            lprasanje.Text = "Прашање: " + prasanja[i].Naslov;
            radioButton1.Text = prasanja[i].Ponudi[0];
            radioButton2.Text = prasanja[i].Ponudi[1];
            radioButton3.Text = prasanja[i].Ponudi[2];
            radioButton4.Text = prasanja[i].Ponudi[3];
           

        }

       
        private string Radiocheck1()
        {
            
                if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                return radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                return radioButton3.Text;
            }
            return radioButton4.Text;
        }
        private int[] random()
        {
            List<int> a = new List<int> { };
            Random r = new Random();
            for (int i = 0; i < brojnaprasanja; i++)
            {
                int n;
                do n = r.Next(0,prasanja.Count);
                while (a.Contains(n));
                a.Add(n);
            }
            return a.ToArray();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            odgovori[--count] = Radiocheck1();
            count++;
            if (count == brojnaprasanja - 1)
            {
                button1.Text = "Заврши";
            }
            if (count > 0)
            {
                button2.Enabled = true;
            }
            if (count == brojnaprasanja)
            {
                
                int points = 0;
                for (int i = 0; i < randombroevi.Length; i++)
                {
                    
                    if (odgovori[i] == prasanja[randombroevi[i]].Tocen)
                    {
                        points++;
                    }
                }
                this.Hide();
                MessageBox.Show("Точни прашања: " + points + "/" + randombroevi.Length);
            }
            else
            {
                
                
                load(randombroevi[count]);
                count++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count-=2;
            load(randombroevi[count]);
            if(count < brojnaprasanja)
            {
                button1.Text = "Следно";
            }
            if(count == 0)
            {
                button2.Enabled = false;
            }
            count++;
        }

     
    }
}
