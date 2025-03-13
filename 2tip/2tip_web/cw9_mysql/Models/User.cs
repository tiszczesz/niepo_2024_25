using System;

namespace cw9_mysql.Models;

public class User
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public int? Age { get; set; }
    public int? RoleId { get; set; }   
    public string? RoleName { get; set; }     
}
