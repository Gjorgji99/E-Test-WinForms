using ETestUI;
using ETestUI.Controller;
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
        List<Question> questions;



        private void ProfesorskoMeni_Load(object sender, EventArgs e)
        {
            questionsBox.MultiColumn = true;
            questions = DataBaseController.loadQuestions();
            foreach (var a in questions)
            {
                questionsBox.Items.Add(a.ToString());
            }
            string broj = "3";
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
                Question question = new Question(titleBox.Text, tb1.Text, tb2.Text, tb3.Text, tb4.Text, correctBox.Text);                
                questionsBox.Items.Add(question.ToString());
                DataBaseController.addQuestion(question);
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
            if (questionsBox.SelectedIndex != -1)
            {
                DataBaseController.deleteQuestion(questions[questionsBox.SelectedIndex]);
                questionsBox.Items.RemoveAt(questionsBox.SelectedIndex);
            }
        }
    }
}
