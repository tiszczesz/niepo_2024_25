

using cw10_wf.Models;

namespace cw10_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbChoice.SelectedIndex = 0;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try {
                int a = Convert.ToInt32(numA.Text);
                int b = Convert.ToInt32(numB.Text);
                Numbers numbers = new Numbers();
                numbers.A = a; 
                numbers.B = b;
                var choice = (cbChoice.SelectedItem as String);
                double result = numbers.Result(choice[0]);
                if (result != -9.99999) {
                    lbResult.Text = result.ToString();
                }
                else {
                    lbResult.Text = "Nie mo¿na dzieliæ przez 0";
                }
                
            }
            catch (FormatException ex) {
                MessageBox.Show("B³êdne liczby");
            }
        }
    }
}
