using MongoDB.Bson.Serialization.Attributes;

namespace Study.MongoDb.Entities;

[BsonDiscriminator(nameof(CarEntity))]
public class CarEntity(string name, int tyres, int doors, int capacity, int cilinders) : VehicleEntity(name, "Car", tyres, doors, capacity)
{
    public int Cilinders { get; set; } = cilinders;
}
