using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Lesson23._04
{
    public partial class Child : Form
    {
        public string Ttext
        {
            set
            {
                textBox1.Text = value;
            }
        }
        public Child()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        public Child(string text)
        {
            InitializeComponent();
            textBox1.Text = text;
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DialogResult ShowDialog(string text)
        {
            textBox1.Text = text;
            return ShowDialog();
        }
    }
}
