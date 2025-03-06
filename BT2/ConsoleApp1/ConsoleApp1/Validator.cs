using System;

namespace BT2
{
    class Validator
    {
        public static int ValidInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out value);

                if (isValid)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Loi! Vui long nhap so nguyen hop le.");
                }
            }
        }
        public static double ValidDouble(string message)
        {
            double value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                bool isValid = double.TryParse(input, out value);

                if (isValid && value >= 0)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Loi! Vui long nhap mot so thuc duong.");
                }
            }
        }
        public static string ValidString(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine().Trim();

                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Loi! Ten san pham khong duoc de trong.");
                }
            }
        }
    }
}
