using System;
using MySql.Data.MySqlClient;

namespace cw2_mysql.Models;

public class StudentsRepo
{
    private readonly string? _connString;
    public StudentsRepo(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("MysqlConnection");
    }
    public List<Student> GetStudents()
    {
        List<Student> students = new List<Student>();
        //wypełnianie listy studentów z bazy danych
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM students";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Student student = new Student();
            student.Id = reader.GetInt32("id");
            student.Firstname = reader.GetString("firstname");
            student.Lastname = reader.GetString("lastname");
            student.GroupId = reader.GetInt32("group_id");
            students.Add(student);
        }
        conn.Close();
        return students;
    }
}
