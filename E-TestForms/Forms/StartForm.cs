using EtestLibrary.Models;
using EtestLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ETestForms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void SetCulture(string culture)
        {
            CultureInfo culture_info = new CultureInfo(culture);
            ComponentResourceManager component_resource_manager
                = new ComponentResourceManager(this.GetType());
            component_resource_manager.ApplyResources(
                this, "$this", culture_info);

            foreach (Control ctl in this.Controls)
            {
                component_resource_manager.ApplyResources(
                    ctl, ctl.Name, culture_info);
            }
        }
        void changeLanguage(string language)
        {
            SetCulture(language);
            Properties.Settings.Default.Language = language;
            Properties.Settings.Default.Save();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            if (language == "en")
            {
                english.Enabled = false;
                macedonian.Enabled = true;
            }
            else
            {
                macedonian.Enabled = false;
                english.Enabled = true;
            }
        }
        private void macedonian_Click(object sender, EventArgs e)
        {
            changeLanguage("mk-MK");
        }

        private void english_Click(object sender, EventArgs e)
        {
            changeLanguage("en");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            DataBaseService.addQuestion(new Question("Што е RAM?", "Read-Only Memory", "Random-Access Memory", "Read-Access Memory", "Random - Only Memory", "Random-Access Memory", Properties.Settings.Default.Language));
            DataBaseService.addQuestion(new Question("Кој од овие не е програмски јазик?", "Java", "JavaSript", "C++", "Pascal", "JavaSript", Properties.Settings.Default.Language));
            DataBaseService.addQuestion(new Question("Кога е создаден Android?", "2007", "2003", "2005", "2004", "2005", Properties.Settings.Default.Language));
            DataBaseService.addQuestion(new Question("Програмскиот јазик Pascal го создал?", "Dennis Ritche", "Richard Stallman", "Niklaus Wirth", "Brendan Eich", "Niklaus Wirth", Properties.Settings.Default.Language));
            DataBaseService.addQuestion(new Question("Кој е основач на Linux-Kernel?", "Linus Torvalds", "Richard Stallman", "Bill Gates", "Dennis Ritchie", "Linus Torvalds", Properties.Settings.Default.Language));

            QuestionsForm test = new QuestionsForm();
            test.StudentName = Tbime.Text;
            this.Hide();
            test.ShowDialog();
        }

        private void profesorMenu_Click(object sender, EventArgs e)
        {
            PasswordForm o = new PasswordForm();
            o.ShowDialog();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            
            changeLanguage(Properties.Settings.Default.Language);
        }
    }
}
