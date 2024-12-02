using System;
using Microsoft.Data.Sqlite;

namespace cw6_sqlite.Models;

public class CarsRepo
{
    private string? conn;

    public CarsRepo(IConfiguration configuration)
    {
        this.conn = configuration.GetConnectionString("sqlite");
    }
    public List<Car> GetCars(){
        List<Car> cars = new ();
        using var connection = new SqliteConnection(conn);
        SqliteCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM cars";
        connection.Open();
        using var reader = command.ExecuteReader();
        while(reader.Read()){
            cars.Add(
                new Car{
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Brand = reader.GetString(2),
                    Year = reader.GetInt32(3),
                    Price = reader.GetDecimal(4)
                }
            );
        }
        return cars;
    }
}
