using System.Globalization;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // private BooksRepo _booksRepo;
        private List<Book> _books;
        private int counter = 0;
        public Form1()
        {
            //_booksRepo = new BooksRepo();

            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _books = BooksRepo.GetBooks("books.txt");
            if (_books.Count > 0) {
                counter = 0;
                UpdateFormBook(_books[counter]);
                pbCount.Maximum = _books.Count-1;
                pbCount.Minimum = 0;
            }

        }

        private void UpdateFormBook(Book book)
        {
            tbTitle.Text = book.Title;
            tbAuthor.Text = book.Author;
            tbYear.Text = book.Year.ToString();
            tbPrice.Text = book.Price.ToString(CultureInfo.InvariantCulture);
            btnDec.Enabled = _books.Count > 0 && counter > 0;
            btnInc.Enabled = _books.Count > 0 && counter < _books.Count - 1;
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            counter--;
            UpdateFormBook(_books[counter]);
            pbCount.Value = counter;
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            counter++;
            UpdateFormBook(_books[counter]);
            pbCount.Value = counter;
        }

      
    }
}
