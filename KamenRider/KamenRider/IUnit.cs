using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamenRider
{
    public interface IUnit
    {
        void attack(Unit target);
        bool isAlive();
    }
}
