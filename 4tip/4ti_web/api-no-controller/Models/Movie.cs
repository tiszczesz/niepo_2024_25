using System;

namespace api_no_controller.Models;

public class Movie
{
    public int Id { get; init; }
    public string? Title { get; init; }
    public string? Director { get; init; }
    public string? Year { get; init; }
}
