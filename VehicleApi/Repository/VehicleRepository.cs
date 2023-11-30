using HyperCaseProject.DataAccessLayer.ApiContext;
using HyperCaseProject.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HyperCaseProjectFatihSoyalp.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleContext _context;

        public VehicleRepository(VehicleContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetCarsByColor(string color)
        {
            return _context.Cars.Where(x => x.Color == color);
        }
        public IEnumerable<Bus> GetBusesByColor(string color) 
        {
            return _context.Buses.Where(x => x.Color == color);
        }
        public IEnumerable<Boat> GetBoatsByColor(string color) 
        {
            return _context.Boats.Where(x => x.Color == color);
        }
        public IEnumerable<Car> ToggleCarHeadLights(int id) 
        {
            var car = _context.Cars.Find(id);
            if(car != null) 
            {
                car.Headlights = !car.Headlights;
                _context.SaveChanges();
            }
            return _context.Cars.Where(x => x.Id == id);
        }
        public IEnumerable<Car> DeleteCar(int id)
        {
            var car = _context.Cars.Find(id);
            if(car != null) 
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
            return _context.Cars.ToList();
        }
        public IEnumerable<Car> GetAllCars() 
        {
            var allCars = _context.Cars;
            return allCars;
        }
        public void AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }
        public IEnumerable<Car> UpdateCar(Car car)
        {
            _context.Cars.Update(car);
            _context.SaveChanges();
            return _context.Cars.Where(c => c.Id == car.Id);
        }

    }
}