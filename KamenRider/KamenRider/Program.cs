using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KamenRider
{
    class Program
    {
        static void Main(string[] args)
        {
            ZeroOne zeroOne = new ZeroOne(1, "Zero-One", 100, 50, 30, Form.BaseForm, 0);
            Saber saber = new Saber(2, "Saber", 120, 60, 25, Form.BaseForm, 0);
            Revice revice = new Revice(3, "Revice", 150, 70, 20, Form.BaseForm, 0);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose Kamen Rider: ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Zero-One");
            Console.WriteLine("2. Saber");
            Console.WriteLine("3. Revice");
            Console.WriteLine("-------------------------");
            Console.Write("Enter your choice (1-3): ");
            Console.ResetColor();

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    Unit? selectedRider = null;
                    switch (choice)
                    {
                        case 1:
                            selectedRider = zeroOne;
                            break;
                        case 2:
                            selectedRider = saber;
                            break;
                        case 3:
                            selectedRider = revice;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice! Please try again.");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Enter your choice (1-3): ");
                            continue;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n----------Rider selected----------");
                    selectedRider.displayInfo();
                    Console.WriteLine("---------BATTLE START!---------\n");
                    Console.ResetColor();

                    while (selectedRider.isAlive())
                    {
                        Humangear humangear = new Humangear(4, "Berotha-Humangia", 10, 40, 20, Form.BaseForm, 20);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\nNew enemy appeared: {humangear.name} (HP: {humangear.hp})!");
                        Console.ResetColor();
                        while (humangear.isAlive() && selectedRider.isAlive())
                        {
                            selectedRider.attack(humangear);
                            if (!humangear.isAlive())
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                int expGain = 10;
                                selectedRider.exp += humangear.exp;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{selectedRider.name} defeated {humangear.name} and gained {expGain} EXP!");
                                Console.ResetColor();
                                selectedRider.displayInfo();
                                Console.WriteLine("\nDo you want to continue fighting? (Y/N)");
                                ConsoleKeyInfo keyInfo = Console.ReadKey();
                                if (keyInfo.Key == ConsoleKey.N)
                                {
                                    Console.WriteLine("\nExiting the game...");
                                    return;
                                }
                                else if (keyInfo.Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine("\nContinuing to the next battle...");
                                    break;
                                }
                            }
                            humangear.attack(selectedRider);
                            if (!selectedRider.isAlive())
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{selectedRider.name} has been defeated!");
                                Console.ResetColor();
                                break;
                            }
                            Console.WriteLine($"\n{selectedRider.name} HP: {selectedRider.hp} | {humangear.name} HP: {humangear.hp}");
                            Console.WriteLine("------------------------------------------------\n");
                        }
                    }
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input! Please enter a number.");
                    Console.ResetColor();
                    Console.WriteLine("\nPress any key to try again...");
                    Console.ReadKey();
                }
            }
        }
    }
}
