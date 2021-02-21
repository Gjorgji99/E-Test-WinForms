using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETestUI
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
            changeNumberBox.Text = broj;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }




        private void addQuestion_Click(object sender, EventArgs e)
        {
            if (tb1.Text == correctBox.Text || tb2.Text == correctBox.Text || tb3.Text == correctBox.Text || tb4.Text == correctBox.Text)
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();
                string line = titleBox.Text + "," + tb1.Text + "," + tb2.Text + "," + tb3.Text + "," + tb4.Text + "," + correctBox.Text;
                lines.Add(line);
                questionsBox.Items.Add(line);
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                ResourceManager rm = new ResourceManager(typeof(ProfesorMenu));
                MessageBox.Show(rm.GetString("correctAnswer"));
            }
        }

        private void changeNumber_Click(object sender, EventArgs e)
        {
            string filePath = (Environment.CurrentDirectory + "\\brojnaprasanja.txt");
            List<string> lines = new List<string> { };
            if (Convert.ToInt32(changeNumberBox.Text) <= questionsBox.Items.Count)
            {
                lines.Add(changeNumberBox.Text);
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                ResourceManager rm = new ResourceManager(typeof(ProfesorMenu));
                MessageBox.Show(rm.GetString("limitNumberQuestions"));

            }
        }

        private void deleteQuestion_Click(object sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            if (questionsBox.SelectedIndex != -1)
            {
                lines.RemoveAt(questionsBox.SelectedIndex);
                File.WriteAllLines(filePath, lines);
                questionsBox.Items.RemoveAt(questionsBox.SelectedIndex);
            }
        }
    }
}
