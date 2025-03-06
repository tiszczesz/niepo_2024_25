using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw16_sqlite
{
    public partial class AddProductform : Form
    {
        private Form1 _mainWindow;
        public AddProductform(Form1 mainwindow)
        {
            InitializeComponent();
            _mainWindow = mainwindow;
            nudPrice.Increment = 0.01m; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
