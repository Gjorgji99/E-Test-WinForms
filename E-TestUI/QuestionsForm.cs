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
using ETestUI;

namespace ETestUI
{
    public partial class QuestionsForm : Form
    {
        public QuestionsForm()
        {
            InitializeComponent();
        }
        ResourceManager rm = new ResourceManager(typeof(QuestionsForm));

        private string studentName;
        Etest test = new Etest(3);

        public string StudentName { get => studentName; set => studentName = value; }

        private void load(Question q)
        {
            lprasanje.Text = rm.GetString("lprasanje.Text") + q.Title;
            radioButton1.Text = q.Offer1;
            radioButton2.Text = q.Offer2;
            radioButton3.Text = q.Offer3;
            radioButton4.Text = q.Offer4;

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





        private void nextButton_Click(object sender, EventArgs e)
        {
            load(test.Next(Radiocheck1()));
            if (test.Count == test.NumberOfQuestions - 1)
            {
                nextButton.Text = rm.GetString("finish");
            }
            if (test.Count > 0)
            {
                backButton.Enabled = true;
            }
            if (test.Count == test.NumberOfQuestions)
            {
                this.Hide();
                MessageBox.Show(rm.GetString("lprasanje.Text") + test.Points + "/" + test.NumberOfQuestions);

            }
        }



        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            backButton.Text = rm.GetString("backButton.Text");
            backButton.Enabled = false;
            lname.Text += StudentName;
            test.Load();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            load(test.Back());
            if (test.Count < test.NumberOfQuestions)
            {
                nextButton.Text = rm.GetString("nextButton.Text");
            }
            if (test.Count == 0)
            {
                backButton.Enabled = false;
            }
        }
    }
}
