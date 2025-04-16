using System;

namespace cw10_cars.Models;

public class User
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? Phone { get; set; }
    public DateOnly DateRental { get; set; }
    public int CarId { get; set; }
}
