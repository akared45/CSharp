using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Models;
using ProductManagement.Repositories;

namespace ProductManagement.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

        public List<Product> SearchProductsByName(string name)
        {
            return _productRepository.SearchProductsByName(name);
        }

        public List<Product> SortProductsByPrice()
        {
            return _productRepository.SortProductsByPrice();
        }
    }
}
