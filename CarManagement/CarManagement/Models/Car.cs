using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Tên: {Name}, Hãng: {Brand}, Giá: {Price}, Số lượng: {Quantity}";
        }
    }
}
