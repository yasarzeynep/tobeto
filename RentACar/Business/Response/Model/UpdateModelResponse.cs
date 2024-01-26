namespace Business;

public class UpdateModelResponse
{
    public string Id { get; set; }
    public int BrandId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public short Year { get; set; }

    public DateTime UpdatedAt { get; set; }
}