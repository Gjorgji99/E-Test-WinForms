using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETestForms.Forms
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager(typeof(ChangePassword));
            string oldPassword = Properties.Settings.Default.Password;
            if(oldPasswordTb.Text == oldPassword)
            {
                Properties.Settings.Default.Password = newPasswordTb.Text;
                Properties.Settings.Default.Save();
                this.Hide();
                MessageBox.Show(rm.GetString("done"));
            }
            else
            {
                MessageBox.Show(rm.GetString("error"));
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
