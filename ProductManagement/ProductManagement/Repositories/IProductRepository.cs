using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Models;

namespace ProductManagement.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        List<Product> SearchProductsByName(string name);
        List<Product> SortProductsByPrice();
    }
}
