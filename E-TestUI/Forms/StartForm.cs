using ETestUI.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETestUI
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
            if(language == "en")
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
