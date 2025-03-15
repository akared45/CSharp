using System;
using System.Collections.Generic;
using CarManagement.Models;
using CarManagement.Repositories;
using CarManagementApp.Repositories;
using CarManagementApp.Services;

namespace CarManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarRepository carRepository = new CarRepository();
            CarService carService = new CarService(carRepository);

            while (true)
            {
                Console.WriteLine("\n===== CAR MANAGEMENT =====");
                Console.WriteLine("1. Add car");
                Console.WriteLine("2. Display car list");
                Console.WriteLine("3. Search car by name");
                Console.WriteLine("4. Delete car by ID");
                Console.WriteLine("5. Sort car by price ascending");
                Console.WriteLine("6. Edit car information by ID");
                Console.WriteLine("7. Exit");
                Console.Write("Select function: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddCar(carService);
                        break;
                    case "2":
                        DisplayAllCars(carService);
                        break;
                    case "3":
                        SearchCarsByName(carService);
                        break;
                    case "4":
                        DeleteCarById(carService);
                        break;
                    case "5":
                        SortCarsByPrice(carService);
                        break;
                    case "6":
                        UpdateCarById(carService);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
        }

        static void AddCar(CarService carService)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter vehicle name: ");
            string name = Console.ReadLine();
            Console.Write("Enter car brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Car car = new Car { Id = id, Name = name, Brand = brand, Price = price, Quantity = quantity };
            carService.AddCar(car);
            Console.WriteLine("Car added successfully!");
        }

        static void DisplayAllCars(CarService carService)
        {
            var cars = carService.GetAllCars();
            if (cars.Count == 0)
            {
                Console.WriteLine("There are no cars.");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }

        static void SearchCarsByName(CarService carService)
        {
            Console.Write("Enter the vehicle name to search for: ");
            string name = Console.ReadLine();
            var cars = carService.SearchCarsByName(name);
            if (cars.Count == 0)
            {
                Console.WriteLine("Vehicle not found.");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }

        static void DeleteCarById(CarService carService)
        {
            Console.Write("Enter vehicle ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            carService.DeleteCar(id);
            Console.WriteLine("Successfully deleted car!");
        }

        static void SortCarsByPrice(CarService carService)
        {
            var cars = carService.SortCarsByPrice();
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        static void UpdateCarById(CarService carService)
        {
            Console.Write("Enter vehicle ID to be repaired: ");
            int id = int.Parse(Console.ReadLine());
            var car = carService.GetCarById(id);
            if (car == null)
            {
                Console.WriteLine("Car not found.");
                return;
            }

            Console.Write("Enter new name: ");
            car.Name = Console.ReadLine();
            Console.Write("Enter new brand: ");
            car.Brand = Console.ReadLine();
            Console.Write("Enter new price: ");
            car.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter new quantity: ");
            car.Quantity = int.Parse(Console.ReadLine());

            carService.UpdateCar(car);
            Console.WriteLine("Car updated successfully!");
        }
    }
}