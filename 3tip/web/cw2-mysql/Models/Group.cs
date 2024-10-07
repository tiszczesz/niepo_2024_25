using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw2_mysql.Models;

public class Group
{
    public int Id { get; set; }
    
    [DisplayName("Nazwa")]
    [Required(ErrorMessage = "Pole Nazwa jest wymagane")]
    [MaxLength(50,ErrorMessage = "Maksymalna długość to 50 znaków")]
    public string? Name { get; set; }
    
    [DisplayName("Opis")]
    [Required(ErrorMessage = "Pole Opis jest wymagane")]
    [MaxLength(100,ErrorMessage = "Maksymalna długość to 100 znaków")]
    public string? Description { get; set; }
    
    
    [DisplayName("Wychowawca")]
    [Required(ErrorMessage = "Pole wychowawca jest wymagane")]
    [MaxLength(50,ErrorMessage = "Maksymalna długość to 50 znaków")]
    public string? Teacher { get; set; }
}
