using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw12.ViewModels;

namespace cw12
{
    public partial class FormInfo : Form
    {
        private Form1 _form1;
        private TextInfoToDGV _textInfoToDGV;
        public FormInfo(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            // string[] cells = new[] { "pierwsza", "fffffff" };
            dataGridView1.Columns.Add("info", "informacja");
            dataGridView1.Columns.Add("value", "wartość");
            _textInfoToDGV = new TextInfoToDGV(_form1.TextInfo);
            foreach (var row in _textInfoToDGV.GetInfo())
            {
                dataGridView1.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
               // File.WriteAllText(saveFileDialog1.FileName, _textInfoToDGV.GetInfo().Join(" "));
            }
        }
    }
}
