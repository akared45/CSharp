using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thread.Model;

namespace Thread.Services
{
    public class Calculator
    {

        private readonly IOperation _operation;

        public Calculator(IOperation operation)
        {
            _operation = operation;
        }

        public async Task<double> CalculateAsync(double a, double b)
        {
            return await _operation.CalculateAsync(a, b);
        }
    }
}

