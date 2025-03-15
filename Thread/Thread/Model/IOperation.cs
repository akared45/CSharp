using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread.Model
{
    public interface IOperation
    {
        Task<double> CalculateAsync(double a, double b);
    }
}
