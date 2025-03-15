using System;
using System.Collections.Generic;
using System.Linq;
using CarManagement.Models;
using CarManagement.Repositories;

namespace CarManagementApp.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly List<Car> _cars = new List<Car>();

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public Car GetCarById(int id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }

        public void UpdateCar(Car car)
        {
            var existingCar = _cars.FirstOrDefault(c => c.Id == car.Id);
            if (existingCar != null)
            {
                existingCar.Name = car.Name;
                existingCar.Brand = car.Brand;
                existingCar.Price = car.Price;
                existingCar.Quantity = car.Quantity;
            }
        }

        public void DeleteCar(int id)
        {
            var car = _cars.FirstOrDefault(c => c.Id == id);
            if (car != null)
            {
                _cars.Remove(car);
            }
        }

        public List<Car> SearchCarsByName(string name)
        {
            return _cars.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Car> SortCarsByPrice()
        {
            return _cars.OrderBy(c => c.Price).ToList();
        }
    }
}