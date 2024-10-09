using System;

namespace cw3_web.Models;

public class Person
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public DateOnly Birthdate { get; set; }
}
