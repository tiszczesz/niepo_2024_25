using cw11_listbox.Models;

namespace cw11_listbox
{

    public partial class Form1 : Form
    {
        private Numbers _numbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGener_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(tbSize.Text);
                _numbers = new Numbers(size);
                lbNumbers.DataSource = _numbers.MyNumbers;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("B³edne dane");
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lbNames.Items
        }
    }
}
