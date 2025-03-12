using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace KamenRider
{
    public class ZeroOne : Unit
    {
        public ZeroOne(int id, string name, int hp, int damage, int speed, Form form, int exp): base(id, name, hp, damage, speed, form,exp) { }

        public override void attack(Unit target)
        {
            Console.WriteLine($"{name} attack enemies with Impact!");
            target.takeDame(damage);
        }
    }
    public class Saber : Unit
    {
        public Saber(int id, string name, int hp, int damage, int speed, Form form, int exp): base(id, name, hp, damage, speed, form, exp) { }

        public override void attack(Unit target)
        {
            Console.WriteLine($"{name} attack enemies with Brave Dragon Strike!");
            target.takeDame(damage);
        }
    }
    public class Revice : Unit
    {
        public Revice(int id, string name, int hp, int damage, int speed, Form form, int exp): base(id, name, hp, damage, speed, form, exp) { }

        public override void attack(Unit target)
        {
            Console.WriteLine($"{name} attack enemies with Rolling ViStrike!");
            target.takeDame(damage);
        }
    }
    public class Humangear : Unit
    {
        public Humangear(int id, string name, int hp, int damage, int speed, Form form,int exp): base(id, name, hp, damage, speed, form, exp) { }

        public override void attack(Unit target)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{name} attacks fiercely!");
            Console.ResetColor();
            target.takeDame(damage);
        }
    }
}

