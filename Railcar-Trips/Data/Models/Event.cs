namespace Railcar_Trips.Data.Models;

public class Event
{
    public int Id { get; set; }
    public required string EventTime { get; set; }
    public int CityId { get; set; }
}