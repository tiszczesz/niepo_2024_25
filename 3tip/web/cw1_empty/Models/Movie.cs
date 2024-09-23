using System;
using System.ComponentModel.DataAnnotations;

namespace cw1_empty.Models;

public class Movie
{

    public int Id { get; set; }

    [Required(ErrorMessage = "Tyuł obowiązkowy")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Tytuł musi mieć od 3 do 100 znaków")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Reżyser obowiązkowy")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Reżyser musi mieć od 3 do 100 znaków")]
    public string? Director { get; set; }

    [Required(ErrorMessage = "Rok obowiązkowy")]
    [Range(1900, 2030, ErrorMessage = "Rok musi być z przedziału 1900-2030")]
    public int? Year { get; set; }
}
