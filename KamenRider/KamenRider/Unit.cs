using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KamenRider
{
    public abstract class Unit : IUnit 
    {
        public int id;
        public string name;
        public int hp;
        public int damage;
        public int speed;
        public Form form;
        public int exp;
        public Unit(int id, string name, int hp, int damage, int speed, Form form, int exp)
        {
            this.id = id;
            this.name = name;
            this.hp = hp;
            this.damage = damage;
            this.speed = speed;
            this.form = form;
            this.exp = exp;
        }
        public void displayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================");
            Console.WriteLine($"         Kamen Rider: {name}");
            Console.WriteLine($"         EXP:{exp}");
            Console.WriteLine("====================================");
            Console.ResetColor();
            Console.WriteLine($"ID      : {id}");
            Console.WriteLine($"Form    : {form}");
            Console.WriteLine($"HP      : {hp}");
            Console.WriteLine($"Damage  : {damage}");
            Console.WriteLine($"Speed   : {speed}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("====================================\n");
            Console.ResetColor();
        }
        public abstract void attack(Unit target);
        public void takeDame(int amount)
        {
            hp -= amount;
            if (hp < 0) hp = 0;

            if (hp > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{name} took {amount} damage! Remaining HP: {hp}\n");
                Console.ResetColor();
            }
        }
        public bool isAlive() => hp > 0;

    }
}
