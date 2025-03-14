using System;
using cw9_mysql.Models;
using MySql.Data.MySqlClient;


public class UsersRepo
{
    private readonly string? _connectionString;
    public UsersRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("mysql");
    }
    public List<User> GetUsers()
    {
        List<User> users = new();
        using var connection = new MySqlConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM users";
        connection.Open();
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            users.Add(
                new User
                {
                    Id = reader.GetInt32("id"),
                    Firstname = reader.GetString("firstname"),
                    Lastname = reader.GetString("lastname"),
                    Age = reader.GetInt32("age"),
                    RoleId = reader.GetInt32("role_id")
                });
        }
        connection.Close();
        return users;
    }
    public List<User> GetUsersWithRoles()
    {
        List<User> users = new();
        using var connection = new MySqlConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText =
        "SELECT u.id,u.firstname,u.lastname,u.age, r.name " +
        " FROM users as u INNER JOIN roles as r ON u.role_id = r.id";
        connection.Open();
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            users.Add(
                new User
                {
                    Id = reader.GetInt32("id"),
                    Firstname = reader.GetString("firstname"),
                    Lastname = reader.GetString("lastname"),
                    Age = reader.GetInt32("age"),
                    RoleId = reader.GetInt32("role_id")
                });
        }
        connection.Close();
        return users;
    }

}
