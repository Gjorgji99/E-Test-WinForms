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

namespace ETestUI
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
