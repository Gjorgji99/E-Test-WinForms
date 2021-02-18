using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etest
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void entry_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Profesor")
            {
                ProfesorskoMeni o = new ProfesorskoMeni();
                o.ShowDialog();
            }
            else
                MessageBox.Show("Внесовте погрешен пасворд");
        }
    }
}
