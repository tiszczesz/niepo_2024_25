using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw8.Models;

public class MyGift
{
    [DisplayName("Nazwa prezentu")]
    [Required(ErrorMessage = "Nazwa prezentu jest wymagana")]
    public string? Name { get; set; }
    
    [DisplayName("Cena")]
    [Required(ErrorMessage = "Cena jest wymagana")]
    [Range(0, 1000, ErrorMessage = "Cena musi być z przedziału 0-1000")]
    public decimal? Price { get; set; }
    
    [DisplayName("Dla kogo")]
    [Required(ErrorMessage = "Pole jest wymagane")]
    public string? Owner { get; set; }
}
