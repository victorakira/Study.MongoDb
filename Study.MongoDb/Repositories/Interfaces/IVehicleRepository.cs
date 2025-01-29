using Study.MongoDb.Entities;

namespace Study.MongoDb.Repositories.Interfaces;

public interface IVehicleRepository
{
    Task AddAsync(CarEntity car);
    Task AddAsync(AirplaneEntity airplane);
    Task<List<CarEntity>> GetCars();
    Task<List<AirplaneEntity>> GetAirplanes();
}
