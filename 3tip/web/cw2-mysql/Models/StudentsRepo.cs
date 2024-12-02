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
        cmd.CommandText = "SELECT students.id,firstname,lastname,group_id, groups.name as name FROM students "
             + "inner join groups on students.group_id = groups.id";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Student student = new Student();
            student.Id = reader.GetInt32("id");
            student.Firstname = reader.GetString("firstname");
            student.Lastname = reader.GetString("lastname");
            student.GroupId = reader.GetInt32("group_id");
            student.GroupName = reader.GetString("name");
            students.Add(student);
        }
        conn.Close();
        return students;
    }
    public List<Group> GetGroups()
    {
        List<Group> groups = new List<Group>();
        //wypełnianie listy grup z bazy danych
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM groups";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            groups.Add(new Group
            {
                Id = reader.GetInt32("id"),
                Name = reader.GetString("name"),
                Description = reader.GetString("description"),
                Teacher = reader.GetString("teacher")
            });
        }

        return groups;
    }

    public List<Student> GetStudentsByGroup(int? id)
    {
        List<Student> students = new();
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = $"SELECT id,firstname,lastname,group_id from students WHERE group_id={id} ";
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

    public Group? GetGroupById(int? id)
    {
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM groups WHERE id=" + id;
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        Group? gruop = null;
        if (reader.HasRows)
        {
            reader.Read();
            gruop = new Group()
            {
                Id = reader.GetInt32("id"),
                Name = reader.GetString("name"),
                Description = reader.GetString("description"),
                Teacher = reader.GetString("teacher")
            };
        }
        conn.Close();
        return gruop;   
    }
}
