using System;
using BT2;

class Program
{
    static void Main()
    {
        List<Product> listProducts = new List<Product>();

        while (true)
        {
            Console.WriteLine("-------Menu------");
            Console.WriteLine("1. Nhap san pham");
            Console.WriteLine("2. Hien thi danh sach san pham");
            Console.WriteLine("3. Thoat");

            int choice = Validator.ValidInt("Chon chuc nang: ");

            switch (choice)
            {
                case 1:
                    Product product = new Product();
                    Console.WriteLine("Nhap san pham");
                    product.Id = Validator.ValidInt("Nhap ID san pham:");
                    product.NameProduct = Validator.ValidString("Nhap ten san pham: ");
                    product.Price = Validator.ValidDouble("Nhap gia san pham: ");
                    listProducts.Add(product);
                    break;
                case 2:
                    if(listProducts.Count==0)
                    {
                        Console.WriteLine("Khong co san pham nao trong danh sach");
                    }
                    else
                    {
                        Console.WriteLine("Hien thi danh sach san pham: ");
                        listProducts.ForEach(
                            p => Console.WriteLine($"ID: {p.Id}, Ten: {p.NameProduct}, Gia: {p.Price} VND")
                        );
                    }
                    break;
                case 3:
                    Console.WriteLine("Thoat");
                    return;
                default:
                    Console.WriteLine("Loi......");
                    break;
            }

        }
    }
}
