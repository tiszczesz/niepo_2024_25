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

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.GetAnimals();
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = 
                DataGridViewAutoSizeColumnsMode.Fill; // auto fill columns
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                Animal selected = dataGridView1.SelectedRows[0].DataBoundItem
                              as Animal;
                if (selected != null) {
                    // MessageBox.Show(selected.Id.ToString());
                    // wype³nienie tbbox
                    // przycisk dodaj noergo zwierzaka 
                    // nowe okno do dodawania zwierzaka
                    // do bazy danych Sqlite
                }
            }
            
        }
    }
}
