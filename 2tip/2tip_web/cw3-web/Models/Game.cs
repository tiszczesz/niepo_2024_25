using System;

namespace cw3_web.Models;

public class Game
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public string? Genre { get; set; }

}
