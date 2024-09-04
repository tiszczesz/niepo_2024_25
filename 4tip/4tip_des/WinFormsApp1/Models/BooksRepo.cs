using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class BooksRepo {

        public static List<Book> GetBooks(string fileName) {
            var lines = File.ReadAllLines(fileName);
            var books = new List<Book>();
            int count = 0;
            var book = new string[4];
            foreach (var line in lines) {
                if (string.IsNullOrEmpty(line)) {
                    count = 0;
                    books.Add(Book.Create(book));
                    continue;
                };
                book[count++] = line;
            }
            books.Add(Book.Create(book));
            return books;
        }
    }
}
