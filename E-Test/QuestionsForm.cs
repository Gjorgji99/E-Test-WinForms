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
    public partial class QuestionsForm : Form
    {
        public QuestionsForm()
        {
            InitializeComponent();
        }
        ResourceManager rm = new ResourceManager(typeof(QuestionsForm));

        private string studentName;
        private List<Question> questions =  new List<Question> { };
        
        int count = 0;
        int numberOfQuestions;
        int[] randomNumbers;
        string[] offers;

        public int NumberOfQuestions { get => numberOfQuestions; set => numberOfQuestions = value; }
        public string StudentName { get => studentName; set => studentName = value; }

        private void load(int i)
        {
            lprasanje.Text = "Прашање: " + questions[i].Title;
            radioButton1.Text = questions[i].Offers[0];
            radioButton2.Text = questions[i].Offers[1];
            radioButton3.Text = questions[i].Offers[2];
            radioButton4.Text = questions[i].Offers[3];


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
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int n;
                do n = r.Next(0,questions.Count);
                while (a.Contains(n));
                a.Add(n);
            }
            return a.ToArray();
        }
        



        private void nextButton_Click(object sender, EventArgs e)
        {
            offers[--count] = Radiocheck1();
            count++;
            if (count == NumberOfQuestions - 1)
            {
                nextButton.Text = "Заврши";
            }
            if (count > 0)
            {
                backButton.Enabled = true;
            }
            if (count == NumberOfQuestions)
            {

                int points = 0;
                for (int i = 0; i < randomNumbers.Length; i++)
                {

                    if (offers[i] == questions[randomNumbers[i]].Correct)
                    {
                        points++;
                    }
                }
                this.Hide();
                MessageBox.Show("Точни прашања: " + points + "/" + randomNumbers.Length);
            }
            else
            {
                load(randomNumbers[count]);
                count++;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            count -= 2;
            load(randomNumbers[count]);
            if (count < NumberOfQuestions)
            {
                nextButton.Text = rm.GetString("nextButton.Text");
            }
            if (count == 0)
            {
                backButton.Enabled = false;
            }
            count++;
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            //backButton.Enabled = false;
            //lname.Text += StudentName;
            //string filePath = (Environment.CurrentDirectory + "\\Prasanja1.txt");
            ////string[] lines = File.ReadeAllLines(filePath);
            //string filePath1 = (Environment.CurrentDirectory + "\\brojnaprasanja.txt");
            //string[] lines1 = File.ReadAllLines(filePath1);
            //NumberOfQuestions = Convert.ToInt32(lines1[0]);

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    string[] parts = lines[i].Split(',');
            //    List<string> offers = new List<string> { };
            //    offers.Add(parts[1]);
            //    offers.Add(parts[2]);
            //    offers.Add(parts[3]);
            //    offers.Add(parts[4]);
            //    questions.Add(new Question(parts[0], offers.ToArray(), parts[5]));
            //}
            //offers = new string[NumberOfQuestions];
            //randomNumbers = random();
            //load(randomNumbers[count]);
            //count++;
        }
    }
}
