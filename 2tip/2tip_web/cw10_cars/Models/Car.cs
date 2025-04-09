using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace cw10_cars.Models;

public class Car
{
    public int Id { get; set; }

    [DisplayName("Marka")]
    [Required(ErrorMessage = "Marka jest wymagana")]
    public string? Brand { get; set; }

    [DisplayName("Model")]
    [Required(ErrorMessage = "Model jest wymagany")]
    public string? Model { get; set; }

    [DisplayName("Rok produkcji")]
    [Required(ErrorMessage = "Rok produkcji jest wymagany")]
    [Range(1900, 2100, ErrorMessage = "Rok produkcji musi być pomiędzy 1900 a 2100")]
    public int? Year { get; set; }

    [DisplayName("Kolor")]
    [Required(ErrorMessage = "Kolor jest wymagany")]
    public string? Color { get; set; }

    [DisplayName("Stan")]
    [Required(ErrorMessage = "Stan jest wymagany")]
    public string? Condition { get; set; }

}
