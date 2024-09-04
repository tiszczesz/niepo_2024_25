using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public static Book? Create(string[] books) {
            if (books.Length != 4) return null;
            try {
                var book = new Book
                {
                    Title = books[0],
                    Author = books[1],
                    Price = Convert.ToDecimal(books[2]),
                    Year = Convert.ToInt32(books[3])
                };
                return book;
            }
            catch (FormatException ex) {
                return null;
            }
        }
    }
}
