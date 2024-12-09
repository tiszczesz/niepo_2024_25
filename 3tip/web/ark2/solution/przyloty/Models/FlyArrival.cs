using System;

namespace przyloty.Models;

public class FlyArrival
{
    public int Id { get; set; }
    public string? VoyageId { get; set; }
    public int PlaneId { get; set; }
    public TimeOnly? ArrivalTime { get; set; }
    public DateOnly? ArrivalsDay { get; set; }
    public string? Status { get; set; }

   
}
