using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw16_sqlite.Models;

namespace cw16_sqlite
{
    public partial class AddProductform : Form
    {
        private MainForm _mainWindow;
        public AddProductform(MainForm mainwindow)
        {
            InitializeComponent();
            _mainWindow = mainwindow;
            nudPrice.Increment = 0.01m;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = tbName.Text,
                Description = tbDescription.Text,
                Price = nudPrice.Value
            };
            _mainWindow.GetRepo().AddProduct(product);
            _mainWindow.ShowInDataGridView();
            Close();
        }
    }
}
