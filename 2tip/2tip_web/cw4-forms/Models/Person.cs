using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw4_forms.Models;

public class Person
{
    [DisplayName("Podaj fajne imię")]
    [Required(ErrorMessage = "Imię jest wymagane")]
    public string? FirstName { get; set; }

    [DisplayName("Podaj nazwisko")]
    [Required(ErrorMessage = "Nazwisko jest wymagane")]
    public string? LastName { get; set; }

    [DisplayName("Podaj wiek")]
    [Required(ErrorMessage = "Wiek jest wymagane")]
    [Range(0, 120, ErrorMessage = "Wiek musi być z zakresu 0-120")]
    public int? Age { get; set; }
}
