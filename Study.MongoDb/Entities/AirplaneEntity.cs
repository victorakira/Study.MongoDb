using MongoDB.Bson.Serialization.Attributes;

namespace Study.MongoDb.Entities;

[BsonDiscriminator(nameof(AirplaneEntity))]
public class AirplaneEntity(string name, int tyres, int doors, int capacity, string airport) : VehicleEntity(name, "AirPlane", tyres, doors, capacity)
{
    public string Airport { get; set; } = airport;
}
