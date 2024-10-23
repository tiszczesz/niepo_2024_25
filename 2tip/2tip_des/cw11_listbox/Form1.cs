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
            int size = Convert.ToInt32(tbSize.Text);
            _numbers = new Numbers(size);
            lbNumbers.DataSource = _numbers.MyNumbers;
        }
    }
}
