using cw16_sqlite.Models;

namespace cw16_sqlite
{
    public partial class Form1 : Form
    {
        private ProductsRepo _repo;
        public Form1()
        {
            InitializeComponent();
            _repo = new ProductsRepo();
           // var products = _repo.GetProducts();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.GetProducts();
        }
    }
}
