using System;

namespace cw6_sqlite.Models;

public class Car
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string?  Brand { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
}
