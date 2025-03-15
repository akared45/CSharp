using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Models;

namespace ProductManagement.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Quantity = product.Quantity;
            }
        }

        public void DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public List<Product> SearchProductsByName(string name)
        {
            return _products.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Product> SortProductsByPrice()
        {
            return _products.OrderBy(p => p.Price).ToList();
        }
    }
}
