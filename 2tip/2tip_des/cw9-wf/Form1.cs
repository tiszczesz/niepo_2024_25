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
}
