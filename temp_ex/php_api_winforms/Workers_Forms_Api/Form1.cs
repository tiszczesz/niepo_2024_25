using Workers_Forms_Api.Models;

namespace Workers_Forms_Api
{
    public partial class Form1 : Form {
        private RepoWorkers _repo = new RepoWorkers();
        private List<Worker> _workers;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _workers = _repo.GetWorkers();
            if (_workers != null && _workers.Count > 0) {
                dataGridView1.DataSource = _workers;
            }
            else {
                MessageBox.Show("Błąd wczytania danych");
            }
        }
    }
}
