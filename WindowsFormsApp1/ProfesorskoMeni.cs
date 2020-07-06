using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProfesorskoMeni : Form
    {
        public ProfesorskoMeni()
        {
            InitializeComponent();
        }

        private void ProfesorskoMeni_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "\\Prasanja1.txt");
            string[] lines = File.ReadAllLines(filePath);
            listBox1.Items.AddRange(lines);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = (appPath + "\\Prasanja12.txt");
            List<string> lines = File.ReadAllLines(filePath).ToList();
            if (listBox1.SelectedIndex != -1)
            {
                lines.RemoveAt(listBox1.SelectedIndex);
                File.WriteAllLines(filePath, lines);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
