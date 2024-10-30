using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private Form1 _form1;
        public Form2(Form1 form1 = null)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _form1.GetName().Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = _form1.GetItems().Text;
        }
    }
}
