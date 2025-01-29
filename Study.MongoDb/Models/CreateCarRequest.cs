namespace Study.MongoDb.Models;

public class CreateCarRequest
{
    public string Name { get; set; } = string.Empty;
    public int Tyres { get; set; }
    public int Doors { get; set; }
    public int Capacity { get; set; }
    public int Cilinders { get; set; }
}
