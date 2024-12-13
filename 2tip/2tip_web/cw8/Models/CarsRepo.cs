using System;

namespace cw8.Models;

public class CarsRepo
{
    public static List<Car> GetCars(){
        return new List<Car>{
            new Car{Id=1, Model="A4", Brand="Audi", Year=2018, Color="Black"},
            new Car{Id=2, Model="A5", Brand="Audi", Year=2019, Color="White"},
            new Car{Id=3, Model="A6", Brand="Audi", Year=2020, Color="Red"},
            new Car{Id=4, Model="A7", Brand="Audi", Year=2021, Color="Blue"}
        };
    }

}

public class Car
{
    public int Id { get; set; }
    public string Model { get; set; }
    public string Brand { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
}