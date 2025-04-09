using System;
using MySql.Data.MySqlClient;

namespace cw10_cars.Models;

public class CarsRepo
{
    private string? _connectionString;
    public CarsRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("mysql");
    }
    public List<Car> GetAllCars(){
        List<Car> cars = new();
        using MySqlConnection conn = new(_connectionString);
        using MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM samochody";
        conn.Open();
        return cars;
    }
}
