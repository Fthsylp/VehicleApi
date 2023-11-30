using HyperCaseProject.DataAccessLayer.ApiContext;
using HyperCaseProject.DataAccessLayer.Models;
using HyperCaseProjectFatihSoyalp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HyperCaseProjectFatihSoyalp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _repository;

        public VehicleController(IVehicleRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("cars/{color}")]
        public IActionResult GetCarsByColor(string color)
        {
            return Ok(_repository.GetCarsByColor(color));
        }
        [HttpGet("boats/{color}")]
        public IActionResult GetBoatsByColor(string color)
        {
            return Ok(_repository.GetBoatsByColor(color));
        }
        [HttpGet("buses/{color}")]
        public IActionResult GetBusesByColor(string color)
        {
            return Ok(_repository.GetBoatsByColor(color));
        }
        [HttpPost("cars/{id}/headlights")]
        public IActionResult ToggleCarHeadlights(int id)
        {
            return Ok(_repository.ToggleCarHeadLights(id));
        }
        [HttpDelete("cars/{id}")]
        public IActionResult DeleteCar(int id)
        {
            var remainingCars = _repository.DeleteCar(id);
            return Ok(remainingCars);
        }
        [HttpGet("cars")]
        public IActionResult GetAllCars()
        {
            var cars = _repository.GetAllCars();
            return Ok(cars);
        }
        [HttpPost("cars")]
        public IActionResult AddCar(Car car)
        {
            _repository.AddCar(car);
            return Ok(car);
        }
        [HttpPut("cars/{id}")]
        public IActionResult UpdateCar(Car car, int id)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }
            var updatedCar = _repository.UpdateCar(car).FirstOrDefault();
            if (updatedCar == null)
            {
                return NotFound();
            }
            return Ok(updatedCar);
        }
    }
}