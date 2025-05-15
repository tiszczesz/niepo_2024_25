using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw10_cars.Models;

public class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Imie jest wymagane")]
    [DisplayName("Imię i nazwisko")]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "Telefon jest wymagany")]
    [DisplayName("Telefon")]
    public string? Phone { get; set; }


    [Required(ErrorMessage = "Data jest wymagana")]
    [DisplayName("Data wypożyczenia")]
    [DataType(DataType.Date)]
    public DateOnly DateRental { get; set; }
    public int CarId { get; set; }
    public Car? CurrentCar { get; set; }
}
