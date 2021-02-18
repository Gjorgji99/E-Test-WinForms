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
    public partial class ProfesorskoMeni : Form
    {
        public ProfesorskoMeni()
        {
            InitializeComponent();
        }
        string filePath;

        

        private void ProfesorskoMeni_Load(object sender, EventArgs e)
        {
            filePath = Path.Combine(Environment.CurrentDirectory + "\\Prasanja12.txt");
            string[] lines = File.ReadAllLines(filePath);
            listBox1.Items.AddRange(lines);
            string filePath1 = (Environment.CurrentDirectory + "\\brojnaprasanja.txt");
            List<string> lines1 = File.ReadAllLines(filePath1).ToList();
            string broj = lines1.ElementAt(0);
            textBox1.Text = broj;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            List<string> lines = File.ReadAllLines(filePath).ToList();
            if (listBox1.SelectedIndex != -1)
            {
                lines.RemoveAt(listBox1.SelectedIndex);
                File.WriteAllLines(filePath, lines);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1.Text == tbt.Text || tb2.Text == tbt.Text || tb3.Text == tbt.Text || tb4.Text == tbt.Text) {
                List<string> lines = File.ReadAllLines(filePath).ToList();
                string line = Tbnaslov.Text + "," + tb1.Text + "," + tb2.Text + "," + tb3.Text + "," + tb4.Text + "," + tbt.Text;
                lines.Add(line);
                listBox1.Items.Add(line);
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                MessageBox.Show("Не е внесен точно точниот одговор");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = (Environment.CurrentDirectory + "\\brojnaprasanja.txt");
            List<string> lines = new List<string> { };
            if (Convert.ToInt32(textBox1.Text) <= listBox1.Items.Count)
            {
                lines.Add(textBox1.Text);
                File.WriteAllLines(filePath, lines);
            }
            else
                MessageBox.Show("Внесовте поголем број на прашања");
        }
    }
}
