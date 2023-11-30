using HyperCaseProject.DataAccessLayer.Models;

namespace HyperCaseProjectFatihSoyalp.Repository
{
    public interface IVehicleRepository
    {
        IEnumerable<Car> GetCarsByColor(string color);
        IEnumerable<Bus> GetBusesByColor(string color);
        IEnumerable<Boat> GetBoatsByColor(string color);
        IEnumerable<Car> ToggleCarHeadLights(int id);
        IEnumerable<Car> DeleteCar(int id);
        IEnumerable<Car> GetAllCars();
        void AddCar(Car car);
        IEnumerable<Car> UpdateCar(Car car);
    }
}
