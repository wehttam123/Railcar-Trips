namespace Railcar_Trips.Data;

public class Railcar
{
    public int Id { get; set; }
    public required string ReportingMark { get; set; }
    public required string CarNumber { get; set; }
    public string? CarType { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
}
