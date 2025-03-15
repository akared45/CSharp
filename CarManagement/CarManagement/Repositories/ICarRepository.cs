using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManagement.Models;

namespace CarManagement.Repositories
{
    public interface ICarRepository
    {
        void AddCar(Car car);
        List<Car> GetAllCars();
        Car GetCarById(int id);
        void UpdateCar(Car car);
        void DeleteCar(int id);
        List<Car> SearchCarsByName(string name);
        List<Car> SortCarsByPrice();
    }
}
