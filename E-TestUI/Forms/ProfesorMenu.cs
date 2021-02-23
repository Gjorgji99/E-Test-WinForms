using ETestUI;
using ETestUI.Controller;
using ETestUI.Forms;
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
        ResourceManager rm = new ResourceManager(typeof(ProfesorMenu));
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
               
                MessageBox.Show(rm.GetString("correctAnswer"));
            }
        }

        private void changeNumber_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(changeNumberBox.Text) <= questionsBox.Items.Count)
            {
                Properties.Settings.Default.NumberOfQuestions = changeNumberBox.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
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

        private void changePassword_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword();
            c.ShowDialog();
        }
    }
}
