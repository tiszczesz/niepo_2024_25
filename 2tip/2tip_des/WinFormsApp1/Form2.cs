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
            switch (_form1.GetItems().Text)
            {
                case "Red":
                    this.BackColor = Color.Red;
                    break;
                case "Green":
                    this.BackColor = Color.Green;
                    break;
                case "Blue":
                    this.BackColor = Color.Blue;
                    break;
                case "Yellow":
                    this.BackColor = Color.Yellow;
                    break;
                default:
                    this.BackColor = Color.Gray;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = _form1.GetDate().SelectionStart.ToShortDateString();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //tutaj kod do wykonania po zamknięciu okna
            _form1.GetLabel().Text = tbForm2.Text.ToUpper();
        }
    }
}
