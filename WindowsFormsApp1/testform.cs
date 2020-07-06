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
        int points = 0;
        int count = 0;
        int brojnaprasanja = 5;
        int[] randombroevi ;
        

        public void setIme(string ime)
        {
            this.ime = ime;
        }

        protected void testform_Load(object sender, EventArgs e)
        {
            lname.Text += ime;
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = (appPath + "\\Prasanja12.txt");
            string[] lines = File.ReadAllLines(filePath);
            for(int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                List<string> odgovor = new List<string> {};
                odgovor.Add(parts[1]);
                odgovor.Add(parts[2]);
                odgovor.Add(parts[3]);
                odgovor.Add(parts[4]);
                prasanja.Add(new Prasanje(parts[0], odgovor.ToArray(), parts[5]));
            }
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
            if(prasanja[i].Tocen == Radiocheck1())
            {
                points++;
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
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
                do n = r.Next(0,brojnaprasanja);
                while (a.Contains(n));
                a.Add(n);
            }
            return a.ToArray();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(count == brojnaprasanja - 1)
            {
                button1.Text = "Заврши";
            }
            if(count == brojnaprasanja)
            {
                this.Hide();
                MessageBox.Show("Точни прашања: " + points);
            }
                load(randombroevi[count]);
            if (count > 0)
            {
                button2.Enabled = true;
            }
            count++;
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
