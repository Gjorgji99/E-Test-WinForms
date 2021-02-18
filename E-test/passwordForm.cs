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
    public partial class passwordForm : Form
    {
        public passwordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Profesor")
            {
                ProfesorMenu o = new ProfesorMenu();
                o.ShowDialog();
            }
            else
                MessageBox.Show("Внесовте погрешен пасворд");
        }

        private void pass_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
