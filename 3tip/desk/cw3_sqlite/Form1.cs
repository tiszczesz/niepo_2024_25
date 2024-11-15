using cw3_sqlite.Models;

namespace cw3_sqlite
{
    public partial class Form1 : Form
    {
        private AnimalsRepo _repo;

        public Form1()
        {
            InitializeComponent();
            _repo = new AnimalsRepo();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dataGridView1.DataSource = _repo.GetAnimals();
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
