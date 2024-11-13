namespace cw12;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            //wczytywanie pliku
            // var result = openFileDialog1.FileName;
            // MessageBox.Show(result);
            var content = File.ReadAllText(openFileDialog1.FileName);
            tbContent.Text = content;
        }

    }

    private void button2_Click(object sender, EventArgs e) {
        new FormInfo(this).ShowDialog();
    }
}
