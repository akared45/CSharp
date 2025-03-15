using System;
using System.Collections.Generic;
using ProductManagement.Models;
using ProductManagement.Repositories;
using ProductManagement.Services;

namespace ProductManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductRepository productRepository = new ProductRepository();
            ProductService productService = new ProductService(productRepository);

            while (true)
            {
                Console.WriteLine("\n===== PRODUCT MANAGEMENT =====");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display product list");
                Console.WriteLine("3. Search product by name");
                Console.WriteLine("4. Delete product by ID");
                Console.WriteLine("5. Sort product by ascending price");
                Console.WriteLine("6. Edit product information by ID");
                Console.WriteLine("7. Exit");
                Console.Write("Select function: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct(productService);
                        break;
                    case "2":
                        DisplayAllProducts(productService);
                        break;
                    case "3":
                        SearchProductsByName(productService);
                        break;
                    case "4":
                        DeleteProductById(productService);
                        break;
                    case "5":
                        SortProductsByPrice(productService);
                        break;
                    case "6":
                        UpdateProductById(productService);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
        }
        static void AddProduct(ProductService productService)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product { Id = id, Name = name, Price = price, Quantity = quantity };
            productService.AddProduct(product);
            Console.WriteLine("Product added successfully!");
        }

        static void DisplayAllProducts(ProductService productService)
        {
            var products = productService.GetAllProducts();
            if (products.Count == 0)
            {
                Console.WriteLine("There are no products.");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }
        }

        static void SearchProductsByName(ProductService productService)
        {
            Console.Write("Enter the product name to search for: ");
            string name = Console.ReadLine();
            var products = productService.SearchProductsByName(name);
            if (products.Count == 0)
            {
                Console.WriteLine("No product found.");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }
        }

        static void DeleteProductById(ProductService productService)
        {
            Console.Write("Enter the product ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            productService.DeleteProduct(id);
            Console.WriteLine("Product deleted successfully!");
        }

        static void SortProductsByPrice(ProductService productService)
        {
            var products = productService.SortProductsByPrice();
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        static void UpdateProductById(ProductService productService)
        {
            Console.Write("Enter the product ID to edit: ");
            int id = int.Parse(Console.ReadLine());
            var product = productService.GetProductById(id);
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter new name: ");
            product.Name = Console.ReadLine();
            Console.Write("Enter new price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter new quantity: ");
            product.Quantity = int.Parse(Console.ReadLine());

            productService.UpdateProduct(product);
            Console.WriteLine("Product updated successfully!");
        }
    }
}