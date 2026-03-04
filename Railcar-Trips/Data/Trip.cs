namespace Railcar_Trips.Data;

public class Trip
{
    public int Id { get; set; }
    public int EquipmentId { get; set; }
    public int? OriginCityId { get; set; }
    public int? DestinationCityId { get; set; }
    public string? StartUTC { get; set; }
    public string? EndUTC { get; set; }
    public int? TotalTripHours { get; set; } = 0;
}
