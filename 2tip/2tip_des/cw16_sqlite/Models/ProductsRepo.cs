using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace cw16_sqlite.Models
{
    public class ProductsRepo
    {
        private string connString = "Data Source=productsDb.db";

        public List<Product> GetProducts() {
            var products = new List<Product>();
            //using SqliteConnection conn = new SqliteConnection(connString);
           // using SqliteConnection conn = new(connString);
            using var conn = new SqliteConnection(connString);
            using var command = conn.CreateCommand();
            //zdefinowanie zapytania do bazy danych
            command.CommandText = "SELECT * FROM products";
            conn.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read()) {
                var product = new Product {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Price = reader.GetDecimal(3)
                };
                products.Add(product);
            }
            conn.Close();
            return products;
        }
    }
}
