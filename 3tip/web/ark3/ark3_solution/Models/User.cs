using System;
using System.ComponentModel;

namespace ark3_solution.Models;

public class User
{
    public int Id { get; set; }
    
    [DisplayName("Imię")]
    public string? FirstName { get; set; }
    
    [DisplayName("Nazwisko")]
    public string? LastName { get; set; }
    
    [DisplayName("telefon")]
    public string?  Phone { get; set; }
    
    [DisplayName("email")]
    public string? Email { get; set; }
}
