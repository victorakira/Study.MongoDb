using Microsoft.AspNetCore.Mvc;
using Study.MongoDb.Models;
using Study.MongoDb.Repositories.Interfaces;

namespace Study.MongoDb.Controllers;
[Route("[controller]")]
[ApiController]
public class HomeController(IVehicleRepository vehicleRepository) : ControllerBase
{
    [HttpGet("car")]
    public async Task<IActionResult> GetCars()
    {
        var result = await vehicleRepository.GetCars();

        return Ok(result);
    }

    [HttpGet("airplane")]
    public async Task<IActionResult> GetAirplanes()
    {
        var result = await vehicleRepository.GetAirplanes();

        return Ok(result);
    }

    [HttpPost("car")]
    public async Task<IActionResult> PostCar(CreateCarRequest request)
    {
        await vehicleRepository.AddAsync(new Entities.CarEntity(request.Name, request.Tyres, request.Doors, request.Capacity, request.Cilinders));

        return Ok();
    }

    [HttpPost("airplane")]
    public async Task<IActionResult> PostAirplane(CreateAirplaneRequest request)
    {
        await vehicleRepository.AddAsync(new Entities.AirplaneEntity(request.Name, request.Tyres, request.Doors, request.Capacity, request.Airport));

        return Ok();
    }
}
