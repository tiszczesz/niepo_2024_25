using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw2_mysql.Models;

public class Student
{
    public int Id { get; set; }
    
    [DisplayName("Imię")]
    [Required(ErrorMessage = "Pole Imię jest wymagane")]
    [MaxLength(50,ErrorMessage = "Maksymalna długość to 50 znaków")]
    public string? Firstname { get; set; }
    
    [DisplayName("Nazwisko")]
    [Required(ErrorMessage = "Pole Nazwisko jest wymagane")]
    [MaxLength(50,ErrorMessage = "Maksymalna długość to 50 znaków")]
    public string? Lastname { get; set; }
    
    [DisplayName("Grupa")]
    public int GroupId { get; set; }

    public string? GroupName { get; set; }
}
