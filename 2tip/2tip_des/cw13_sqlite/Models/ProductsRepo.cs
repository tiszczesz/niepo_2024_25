using System;
using Microsoft.Data.Sqlite;

namespace cw13_sqlite.Models;

public class ProductsRepo
{
    private readonly string _connectionString = "Data Source=productsDb.db";

    public List<Product> GetProducts(){
        List<Product> products = new();
        //tworzenie obiektu połączenia z bazą danych
        using SqliteConnection conn = new SqliteConnection(_connectionString);
        //tworzenie obiektu komend
        SqliteCommand command = conn.CreateCommand();
        //ustawienie zapytania sql
        command.CommandText = "SELECT * FROM products";
        //otwarcie połączenia
        conn.Open();
        //wykonanie zapytania
        SqliteDataReader reader = command.ExecuteReader();
        //odczytanie wyników zapytania
        while(reader.Read()){
            products.Add(
                new Product{
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetDecimal(2),
                    Description = reader.GetString(3)
                }
            );
        }
        return products;
    }

}
