using System;

namespace cw8.Models;

public class CarsRepo
{
    public static List<MyCar> GetCars(){
        return new List<MyCar>{
            new MyCar{Id=1, Model="A4", Brand="Audi", Year=2018, Color="Black"},
            new MyCar{Id=2, Model="A5", Brand="Audi", Year=2019, Color="White"},
            new MyCar{Id=3, Model="A6", Brand="Audi", Year=2020, Color="Red"},
            new MyCar{Id=4, Model="A7", Brand="Audi", Year=2021, Color="Blue"}
        };
    }

}

public class MyCar
{
    public int Id { get; set; }
    public string Model { get; set; }
    public string Brand { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
}