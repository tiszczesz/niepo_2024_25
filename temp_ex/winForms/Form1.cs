using System.Text.Json;
using System.Text.Json.Nodes;

namespace winForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
        Numbers n1 = new Numbers();
        n1.A = Convert.ToInt32(tb1.Text);
        n1.B = Convert.ToInt32(tb2.Text);
        string dane = JsonSerializer.Serialize(n1);
        File.WriteAllText("dd.json", dane);
    }
}
