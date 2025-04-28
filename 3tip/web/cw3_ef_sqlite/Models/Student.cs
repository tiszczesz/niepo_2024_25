using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw3_ef_sqlite.Models;

public class Student
{
    public int Id { get; set; }

    [DisplayName("Imię")]
    [Required(ErrorMessage = "Imię jest wymagane")]
    public string Firstname { get; set; }

    [DisplayName("Nazwisko")]
    [Required(ErrorMessage = "Nazwisko jest wymagane")]
    public string Lastname { get; set; }

    [DisplayName("Numer indeksu")]
    [Required(ErrorMessage = "Numer indeksu jest wymagany")]
    public string IndexNumber { get; set; }

    [DisplayName("Data urodzenia")]
    [Required(ErrorMessage = "Data urodzenia jest wymagana")]
    public DateOnly? Birthdate { get; set; }
}
