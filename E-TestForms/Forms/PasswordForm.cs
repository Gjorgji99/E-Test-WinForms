using System;
using System.Resources;
using System.Windows.Forms;

namespace ETestForms
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void entry_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == Properties.Settings.Default.Password)
            {
                ProfesorMenu o = new ProfesorMenu();
                o.ShowDialog();
            }
            else
            {
                ResourceManager rm = new ResourceManager(typeof(PasswordForm));
                MessageBox.Show(rm.GetString("passwordError"));
            }
        }
    }
}
