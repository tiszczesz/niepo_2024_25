namespace cw9_wf;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        label1.Visible = label1.Visible ? false : true;
    }

    private void button2_Click(object sender, EventArgs e) {
        var rnd = new Random();
        var colors = new Color[] {
            Color.Red, 
            Color.Green,
            Color.Blue, 
            Color.Yellow, 
            Color.Purple
        };
        if (pColor.BackColor != Color.Red) {
            pColor.BackColor = Color.Red;
        }
        else {
            pColor.BackColor = Color.Green;
        }
        
    }
}
