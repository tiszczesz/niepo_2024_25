using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw12
{
    public partial class FormInfo : Form
    {
        private Form1 _form1;
        public FormInfo(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormInfo_Load(object sender, EventArgs e) {
            DataGridViewRow row = new DataGridViewRow();
            string[] cels = new[] { "pierwsza", "fffffff" };
            row.CreateCells(cels);
            dataGridView1.Rows.Add(row);
        }
    }
}
