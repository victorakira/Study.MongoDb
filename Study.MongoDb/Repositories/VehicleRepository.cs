using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Study.MongoDb.Entities;
using Study.MongoDb.Repositories.Interfaces;

namespace Study.MongoDb.Repositories;

public class VehicleRepository : MongoRepository, IVehicleRepository
{
    private readonly IMongoCollection<VehicleEntity> _collection;
    public VehicleRepository(IConfiguration configuration) : base(configuration)
    {
        _collection = Database.GetCollection<VehicleEntity>("Vehicle");
    }

    public Task AddAsync(CarEntity car)
    {
        return _collection.InsertOneAsync(car);
    }

    public Task AddAsync(AirplaneEntity airplane)
    {
        return _collection.InsertOneAsync(airplane);
    }

    public Task<List<AirplaneEntity>> GetAirplanes()
    {
        var filter = Builders<VehicleEntity>.Filter.Eq("_t", nameof(AirplaneEntity));
        return _collection.Find(filter).As<AirplaneEntity>().ToListAsync();
    }

    public Task<List<CarEntity>> GetCars()
    {
        var filter = Builders<VehicleEntity>.Filter.Eq("_t", nameof(CarEntity));
        return _collection.Find(filter).As<CarEntity>().ToListAsync();
    }
}
