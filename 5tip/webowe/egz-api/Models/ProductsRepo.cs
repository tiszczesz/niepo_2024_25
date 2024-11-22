using System;
using System.Data;
using Microsoft.Data.Sqlite;

namespace egz_api.Models;

public class ProductsRepo
{
    private string connString;
    public ProductsRepo(string connString)
    {
        this.connString = connString;
    }
    public List<Product> GetProducts(){
        List<Product> products = new();
        using SqliteConnection conn = new SqliteConnection(connString);
        SqliteCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM Product";
        conn.Open();
        SqliteDataReader reader = cmd.ExecuteReader();
        if(!reader.HasRows){
            conn.Close();
            return products;
        }
        while(reader.Read()){
            products.Add(
                new Product{
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Description = reader.GetString("description"),
                    Price = reader.GetDecimal("price")
                }
            );
        }
        conn.Close();
        return products;
    }
}
