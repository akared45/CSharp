using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thread.Model;

namespace Thread.Strategies
{
    public class SubtractOperation : IOperation
    {
        public async Task<double> CalculateAsync(double a, double b)
        {
            await Task.Delay(1000);
            return a - b;
        }
    }
}
