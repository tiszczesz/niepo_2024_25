using System;

namespace cw3_ef_sqlite.Models;

public class Student
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string IndexNumber { get; set; }
    public DateOnly Birthdate { get; set; }
}
