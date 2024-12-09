using System;
using MySql.Data.MySqlClient;

namespace przyloty.Models;

public class ArrivalsRepo
{
    private string? _connectionString;
    public ArrivalsRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("mysql");
    }
    public List<FlyArrival> GetArrivals()
    {
        List<FlyArrival> arrivals = new();
        using var connection = new MySqlConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM przyloty";
        connection.Open();
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            FlyArrival arrival = new()
            {
                Id = reader.GetInt32("id"),
                VoyageId = reader.GetString("nr_rejsu"),
                PlaneId = reader.GetInt32("samoloty_id"),
                ArrivalTime = TimeOnly.FromTimeSpan(reader.GetTimeSpan("czas")),
                ArrivalsDay =DateOnly.FromDateTime( reader.GetDateTime("dzien")),
                Status = reader.GetString("status_lotu")
            };
            arrivals.Add(arrival);
        }
        return arrivals;
    }
   
}
