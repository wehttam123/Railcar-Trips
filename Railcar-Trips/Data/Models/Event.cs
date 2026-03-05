namespace Railcar_Trips.Data.Models;

public class Event
{
    public int Id { get; set; }
    public string EventCode { get; set; }
    public DateTime EventTime { get; set; }
    public int CityId { get; set; }

    public string EquipmentId { get; set; }
}