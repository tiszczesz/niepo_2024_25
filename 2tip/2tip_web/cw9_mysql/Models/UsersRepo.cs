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
        "SELECT u.id,u.firstname,u.lastname,u.age, r.name as name " +
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
                    //RoleId = reader.GetInt32("role_id"),
                    RoleName = reader.GetString("name")
                });
        }
        connection.Close();
        return users;
    }

    internal User? GetUserById(int id)
    {
        using var conn = new MySqlConnection(_connectionString);
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT u.id as id,u.firstname as firstname,u.lastname as lastname,u.age as age, r.name as name " +
        " FROM users as u INNER JOIN roles as r ON u.role_id = r.id " + "WHERE u.id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        User? user = null;
        using var reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
            reader.Read();
            user = new User
            {
                Id = reader.GetInt32("id"),
                Firstname = reader.GetString("firstname"),
                Lastname = reader.GetString("lastname"),
                Age = reader.GetInt32("age"),
                RoleName = reader.GetString("name")
            };
        }
        conn.Close();
        return user;
    }
}
