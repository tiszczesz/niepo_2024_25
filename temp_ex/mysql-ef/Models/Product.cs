using System;
using System.ComponentModel;

namespace mysql_ef.Models;

public class Product
{
    public int Id { get; set; }
    
    [DisplayName("Nazwa produktu")]
    public string? Name { get; set; }
    
    [DisplayName("Cena")]
    public decimal Price { get; set; }
    
    [DisplayName("Data produkcji")]
    public DateOnly? ProdDate { get; set; }
    
    [DisplayName("Kategoria")]
    public string? Category { get; set; }

}
