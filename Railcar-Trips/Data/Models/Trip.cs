namespace Railcar_Trips.Data.Models;

public class Trip
{
    public int Id { get; set; }
    public string EquipmentId { get; set; }
    public int OriginCityId { get; set; }
    public int? DestinationCityId { get; set; }
    public DateTime? StartUTC { get; set; }
    public DateTime? EndUTC { get; set; }
    public double? TotalTripHours { get; set; } = 0;
}
