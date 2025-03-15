using System;
using System.Threading.Tasks;
using Thread.Services;
using Thread.Model;
using Thread.Strategies;

namespace CalculatorApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter number one : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number two : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            IOperation addOperation = new AddOperation();
            IOperation subtractOperation = new SubtractOperation();
            IOperation multiplyOperation = new MultiplyOperation();
            IOperation divideOperation = new DivideOperation();

            Calculator addCalculator = new Calculator(addOperation);
            Calculator subtractCalculator = new Calculator(subtractOperation);
            Calculator multiplyCalculator = new Calculator(multiplyOperation);
            Calculator divideCalculator = new Calculator(divideOperation);

            double sum = await addCalculator.CalculateAsync(num1, num2);
            double difference = await subtractCalculator.CalculateAsync(num1, num2);
            double product = await multiplyCalculator.CalculateAsync(num1, num2);
            double quotient = await divideCalculator.CalculateAsync(num1, num2);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }
    }
}