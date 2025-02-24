using System;
using MySql.Data.MySqlClient;

namespace ark3_solution.Models;

public class NoticesRepo
{
    private string? connectionString;

    public NoticesRepo(IConfiguration configuration)
    {
        connectionString = configuration.GetConnectionString("mysql");
    }
    public List<Category> GetCategories()
    {
        List<Category> categories = new List<Category>();
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM kategoria";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Category category = new Category();
            category.Id = reader.GetInt32(0);
            category.Name = reader.GetString(1);
            categories.Add(category);
        }
        conn.Close();
        return categories;
    }
    public List<SubCategory> GetSubCategories()
    {
        List<SubCategory> subCategories = new List<SubCategory>();
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM podkategoria";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            SubCategory subCategory = new SubCategory();
            subCategory.Id = reader.GetInt32(0);
            subCategory.Name = reader.GetString(1);
            subCategory.CategoryId = reader.GetInt32(2);
            subCategories.Add(subCategory);
        }
        conn.Close();
        return subCategories;
    }

    public void SaveUser(User user)
    {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO uzytkownik (imie, nazwisko, telefon, email) VALUES (@imie, @nazwisko, @telefon, @email)";
        cmd.Parameters.AddWithValue("@imie", user.FirstName);
        cmd.Parameters.AddWithValue("@nazwisko", user.LastName);
        cmd.Parameters.AddWithValue("@telefon", user.Phone);
        cmd.Parameters.AddWithValue("@email", user.Email);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}
