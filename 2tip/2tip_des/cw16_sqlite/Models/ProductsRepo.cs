using System;
using System.Collections.Generic;
using System.Globalization;
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
        public void AddProduct(Product product)
        {
            using var conn = new SqliteConnection(connString);
            using var command = conn.CreateCommand();
            //tutaj problem z przecinkiem w double!!!! CultuerInfo.InvariantCulture
            //command.CommandText = "INSERT INTO products(name, description, price)"
            //                      + $" VALUES ('{product.Name}','{product.Description}',{product.Price.ToString(CultureInfo.InvariantCulture)})";


            //Parametryzacja zapytania SQL - zabezpieczenie przed SQL Injection
            //nie trzeba ręcznie zamieniać przecinka na kropkę
            command.CommandText =
                "INSERT INTO products (name, description, price) VALUES ($name, $description, $price)";
            command.Parameters.AddWithValue("$name", product.Name);
            command.Parameters.AddWithValue("$description", product.Description);
            command.Parameters.AddWithValue("$price", product.Price);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public  void DeleteProduct(Product product)
        {
            using SqliteConnection conn = new SqliteConnection(connString);
            using SqliteCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM products WHERE id = $id";
            command.Parameters.AddWithValue("$id", product.Id);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
