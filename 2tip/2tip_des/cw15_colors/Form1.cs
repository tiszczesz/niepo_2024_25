namespace cw15_colors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbRed_ValueChanged(object sender, EventArgs e)
        {
            lbRed.Text = $"Red: {tbRed.Value}";
            UpdateColor();
        }

        private void tbGreen_ValueChanged(object sender, EventArgs e)
        {
            lbGreen.Text = $"Green: {tbGreen.Value}";
            UpdateColor();
        }

        private void tbBlue_ValueChanged(object sender, EventArgs e)
        {
            lbBlue.Text = $"Blue: {tbBlue.Value}";
            UpdateColor();
        }

        private void tbOpacity_ValueChanged(object sender, EventArgs e)
        {
            lbOpacity.Text = $"Opacity: {tbOpacity.Value}";
            UpdateColor();
        }

        private void UpdateColor()
        {
            panel1.BackColor = Color.FromArgb(
                tbOpacity.Value,
                tbRed.Value,
                tbGreen.Value,
                tbBlue.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }
}
