using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Study.MongoDb.Entities;

[BsonDiscriminator(RootClass = true)]
[BsonKnownTypes(typeof(CarEntity), typeof(AirplaneEntity))]
public abstract class VehicleEntity(string name, string type, int tyres, int doors, int capacity)
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
    public string Name { get; set; } = name;
    public string Type { get; set; } = type;
    public int Tyres { get; set; } = tyres;
    public int Doors { get; set; } = doors;
    public int Capacity { get; set; } = capacity;
}