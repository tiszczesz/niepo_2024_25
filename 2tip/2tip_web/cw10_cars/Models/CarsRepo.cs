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
    public List<Car> GetAllCars()
    {
        List<Car> cars = new();
        using MySqlConnection conn = new(_connectionString);
        using MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM samochody";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Car car = new()
            {
                Id = reader.GetInt32("id"),
                Brand = reader.GetString("marka"),
                Model = reader.GetString("model"),
                Year = reader.GetInt32("rocznik"),
                Color = reader.GetString("kolor"),
                Condition = reader.GetString("stan")
            };
            cars.Add(car);
        }
        return cars;
    }
    public Car? GetCarById(int id)
    {
        using MySqlConnection conn = new(_connectionString);
        using MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM samochody WHERE id=@id";
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        if (!reader.HasRows) return null;
        reader.Read();
        Car car = new()
        {
            Id = reader.GetInt32("id"),
            Brand = reader.GetString("marka"),
            Model = reader.GetString("model"),
            Year = reader.GetInt32("rocznik"),
            Color = reader.GetString("kolor"),
            Condition = reader.GetString("stan")
        };
        conn.Close();
        return car;
    }

    public void AddCarRental(User user)
    {
        using MySqlConnection conn = new(_connectionString);
        using MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO zamowienia (Klient, telefon, dataZam, Samochody_id) "
          + " VALUES (@name, @phone, @date, @carId)";
        cmd.Parameters.AddWithValue("@name", user.UserName);
        cmd.Parameters.AddWithValue("@phone", user.Phone);
        cmd.Parameters.AddWithValue("@date", user.DateRental.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@carId", user.CarId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}
