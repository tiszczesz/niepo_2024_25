using cw2.Models;

namespace cw2;

public partial class Form1 : Form {
    private AnimlasRepo _repo;
    public Form1()
    {
        InitializeComponent();
        dataGridView1.ReadOnly = true;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _repo = new AnimlasRepo();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        var animals = _repo.GetAnimals();
        dataGridView1.DataSource = animals;
        dataGridView1.Columns["Weight"]!.DefaultCellStyle.Alignment = 
                DataGridViewContentAlignment.MiddleRight;
        dataGridView1.Columns["Age"]!.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;
        dataGridView1.Columns["Id"]!.Visible = false;
      
        
    }
}
