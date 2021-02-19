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

namespace Etest
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void SetCulture(string culture)
        {
            // Make the CultureInfo.
            CultureInfo culture_info = new CultureInfo(culture);

            // Make a ComponentResourceManager.
            ComponentResourceManager component_resource_manager
                = new ComponentResourceManager(this.GetType());

            // Apply resources to the form.
            component_resource_manager.ApplyResources(
                this, "$this", culture_info);

            // Apply resources to the form's controls.
            foreach (Control ctl in this.Controls)
            {
                component_resource_manager.ApplyResources(
                    ctl, ctl.Name, culture_info);
            }
        }
        private void macedonian_Click(object sender, EventArgs e)
        {
            SetCulture("mk-MK");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("mk-MK");
            macedonian.Enabled = false;
            english.Enabled = true;
        }

        private void english_Click(object sender, EventArgs e)
        {
            SetCulture("en");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            english.Enabled = false;
            macedonian.Enabled = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            QuestionsForm test = new QuestionsForm();
            test.setIme(Tbime.Text);
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
            SetCulture("en");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            english.Enabled = false;
            macedonian.Enabled = true;
        }
    }
}
