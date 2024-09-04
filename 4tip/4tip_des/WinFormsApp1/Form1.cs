using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
       // private BooksRepo _booksRepo;
        public Form1()
        {
            //_booksRepo = new BooksRepo();
            var books = BooksRepo.GetBooks("books.txt");
            InitializeComponent();
        }
    }
}
