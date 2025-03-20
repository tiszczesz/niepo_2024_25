using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw9_mysql.Models;

public class User
{
    public int Id { get; set; }
    
    [DisplayName("Imię")]
    [Required(ErrorMessage = "Podaj imię")]
    [MaxLength(50, ErrorMessage = "Imię jest za długie")]
    public string? Firstname { get; set; }
    
    [Required(ErrorMessage = "Podaj nazwisko")]
    [MaxLength(50, ErrorMessage = "Nazwisko jest za długie")]
    [DisplayName("Nazwisko")]
    public string? Lastname { get; set; }
    
    [Range(0, 120, ErrorMessage = "Wiek musi być z przedziału 0-120")]
    [Required(ErrorMessage = "Podaj wiek")]
    [DisplayName("Wiek")]
    public int? Age { get; set; }
    
    [DisplayName("Rola")]
    public int? RoleId { get; set; }   
    public string? RoleName { get; set; }     
}
