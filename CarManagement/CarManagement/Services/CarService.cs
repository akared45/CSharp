using CarManagement.Models;
using CarManagement.Repositories;

namespace CarManagementApp.Services
{
    public class CarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public Car GetCarById(int id)
        {
            return _carRepository.GetCarById(id);
        }

        public void UpdateCar(Car car)
        {
            _carRepository.UpdateCar(car);
        }

        public void DeleteCar(int id)
        {
            _carRepository.DeleteCar(id);
        }

        public List<Car> SearchCarsByName(string name)
        {
            return _carRepository.SearchCarsByName(name);
        }

        public List<Car> SortCarsByPrice()
        {
            return _carRepository.SortCarsByPrice();
        }
    }
}