using cw12.Models;

namespace cw12;

public partial class Form1 : Form {
    public FileTextInfo TextInfo;
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
            var content = File.ReadAllLines(openFileDialog1.FileName);
            tbContent.Lines = content;
            TextInfo = new FileTextInfo(content);
        }

    }

    private void button2_Click(object sender, EventArgs e) {
        new FormInfo(this).ShowDialog();
    }
}
