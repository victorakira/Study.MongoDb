namespace Study.MongoDb.Models;

public class CreateAirplaneRequest
{
    public string Name { get; set; } = string.Empty;
    public int Tyres { get; set; }
    public int Doors { get; set; }
    public int Capacity { get; set; }
    public string Airport { get; set; } = string.Empty;
}
