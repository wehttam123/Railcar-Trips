namespace Railcar_Trips.Data;

public class City
{
    public int CityId { get; set; }
    public required string CityName { get; set; }
    public required string TimeZone { get; set; }
    public string? Country { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
}
