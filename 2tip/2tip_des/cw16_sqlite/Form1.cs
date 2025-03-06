using cw16_sqlite.Models;

namespace cw16_sqlite {
    public partial class Form1 : Form {
        private ProductsRepo _repo;

        public Form1() {
            InitializeComponent();
            _repo = new ProductsRepo();
            // var products = _repo.GetProducts();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            ShowInDataGridView();
        }

        private void ShowInDataGridView() {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = _repo.GetProducts();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Description"]
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAddNew_Click(object sender, EventArgs e) {
            new AddProductform(this).ShowDialog();
        }

        public ProductsRepo GetRepo() {
            return _repo;
        }
    }
}



