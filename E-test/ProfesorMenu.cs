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

namespace Etest
{
    public partial class ProfesorMenu : Form
    {
        public ProfesorMenu()
        {
            InitializeComponent();
        }
        string filePath;

        

        private void ProfesorskoMeni_Load(object sender, EventArgs e)
        {
            filePath = Path.Combine(Environment.CurrentDirectory + "\\Prasanja12.txt");
            string[] lines = File.ReadAllLines(filePath);
            questionsBox.Items.AddRange(lines);
            string filePath1 = (Environment.CurrentDirectory + "\\brojnaprasanja.txt");
            List<string> lines1 = File.ReadAllLines(filePath1).ToList();
            string broj = lines1.ElementAt(0);
            numberQuestionsBox.Text = broj;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
            List<string> lines = File.ReadAllLines(filePath).ToList();
            if (questionsBox.SelectedIndex != -1)
            {
                lines.RemoveAt(questionsBox.SelectedIndex);
                File.WriteAllLines(filePath, lines);
                questionsBox.Items.RemoveAt(questionsBox.SelectedIndex);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstBox.Text == correctBox.Text || secoundBox.Text == correctBox.Text || thirdBox.Text == correctBox.Text || fourBox.Text == correctBox.Text) {
                List<string> lines = File.ReadAllLines(filePath).ToList();
                string line = titleBox.Text + "," + firstBox.Text + "," + secoundBox.Text + "," + thirdBox.Text + "," + fourBox.Text + "," + correctBox.Text;
                lines.Add(line);
                questionsBox.Items.Add(line);
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
            if (Convert.ToInt32(numberQuestionsBox.Text) <= questionsBox.Items.Count)
            {
                lines.Add(numberQuestionsBox.Text);
                File.WriteAllLines(filePath, lines);
            }
            else
                MessageBox.Show("Внесовте поголем број на прашања");
        }
    }
}
