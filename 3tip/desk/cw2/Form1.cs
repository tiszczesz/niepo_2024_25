using cw2.Models;

namespace cw2;

public partial class Form1 : Form {
    private AnimlasRepo _repo;
    public Form1()
    {
        InitializeComponent();
        _repo = new AnimlasRepo();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        var animals = _repo.GetAnimals();
        dataGridView1.DataSource = animals;
    }
}
