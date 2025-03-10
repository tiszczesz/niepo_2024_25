using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ark3_solution.Models;

public class NoticeFull
{

    public int Id { get; set; }
    
    [Required(ErrorMessage = "Pole tytuł jest wymagane")]
    [DisplayName("Tytuł")]
    public string? Title { get; set; }


    [Required(ErrorMessage = "Pole tytuł jest wymagane")]
    [DisplayName("Treść ogłoszenia")]
    public string? Content { get; set; }
    
    
    [DisplayName("Imię")]
    public string? FirstName { get; set; }
   
   public int? UserId { get; set; }


    
    [DisplayName("Nazwisko")]
    public string? LastName { get; set; }
    
    [DisplayName("Kategoria")]
    public  string? CategoryName { get; set; }
    public int? CategoryId { get; set; }
    
    [DisplayName("Podkategoria")]
    public string? SubCategoryName { get; set; }
    public int? SubCategoryId { get; set; }
}
