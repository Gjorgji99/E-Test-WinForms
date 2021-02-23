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
        private void macedonian_Click(object sender, EventArgs e)
        {
            SetCulture("mk-MK");
            Properties.Settings.Default.Language = "mk-MK";
            Properties.Settings.Default.Save();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
            macedonian.Enabled = false;
            english.Enabled = true;
        }

        private void english_Click(object sender, EventArgs e)
        {
            SetCulture("en");
            Properties.Settings.Default.Language = "en";
            Properties.Settings.Default.Save();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            english.Enabled = false;
            macedonian.Enabled = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            QuestionsForm test = new QuestionsForm(Tbime.Text);
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
            if (Properties.Settings.Default.Language == "mk-MK")
            {
                english.Enabled = true;
                macedonian.Enabled = false;
                SetCulture("mk-MK");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
            }
            else
            {
                SetCulture("en");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                english.Enabled = false;
                macedonian.Enabled = true;
            }
            
        }
    }
}
