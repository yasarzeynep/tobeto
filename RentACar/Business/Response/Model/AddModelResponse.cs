namespace Business;

public class AddModelResponse
{
    public int Id { get; set; }
    public int BrandId { get; set; } //normalizasyon; ornek:BMW marka arabasının bir Id si var
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public short Year { get; set; }

    public DateTime Created { get; set; }

}