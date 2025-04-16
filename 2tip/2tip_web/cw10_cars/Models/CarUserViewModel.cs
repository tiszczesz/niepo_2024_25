using System;

namespace cw10_cars.Models;

public class CarUserViewModel
{
    public Car? CarToRental { get; set; }
    public User User { get; set; } = new User();
}
