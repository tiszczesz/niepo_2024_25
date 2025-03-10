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
    private void SaveG(){
        //TODO
        Console.WriteLine("SaveG");
    }
    public void ShowSaveG(){
        SaveG();
    }

    public List<NoticeFull> GetNoticesFull(){
        var notices = new List<NoticeFull>();
        using MySqlConnection conn = new MySqlConnection(connectionString);
        using MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = @"SELECT ogloszenie.tresc, uzytkownik.imie,uzytkownik.nazwisko ,kategoria.nazwa,podkategoria.nazwa
                            from ogloszenie INNER JOIN uzytkownik 
                            on ogloszenie.uzytkownik_id=uzytkownik.id
                            INNER join kategoria on ogloszenie.kategoria=kategoria.id
                            INNER join podkategoria on ogloszenie.podkategoria=podkategoria.id";
        conn.Open();
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            NoticeFull notice = new NoticeFull();
            notice.Content = reader.GetString(0);
            notice.FirstName = reader.GetString(1);
            notice.LastName = reader.GetString(2);
            notice.CategoryName = reader.GetString(3);
            notice.SubCategoryName = reader.GetString(4);
            notices.Add(notice);
        }
        conn.Close();
        return notices;
    }

    public void SaveNotice(NoticeFull notice)
    {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO ogloszenie (tytul,tresc, uzytkownik_id, kategoria, podkategoria) VALUES (@tytul,@tresc, @uzytkownik_id, @kategoria, @podkategoria)";
        cmd.Parameters.AddWithValue("@tytul", notice.Title);
        cmd.Parameters.AddWithValue("@tresc", notice.Content);
        cmd.Parameters.AddWithValue("@uzytkownik_id", notice.UserId);
        cmd.Parameters.AddWithValue("@kategoria", notice.CategoryId);
        cmd.Parameters.AddWithValue("@podkategoria", notice.SubCategoryId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public List<User> GetUsers()
    {
        List<User> users = new List<User>();
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM uzytkownik";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            User user = new User();
            user.Id = reader.GetInt32(0);
            user.FirstName = reader.GetString(1);
            user.LastName = reader.GetString(2);
            user.Phone = reader.GetString(3);
            user.Email = reader.GetString(4);
            users.Add(user);
        }
        conn.Close();
        return users;
    }
}




