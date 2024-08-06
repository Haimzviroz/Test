using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Calculator
    {
        public double  Add(double x, double y)
        {

        return x + y; }
    }
    public class MathOperations
    {
        public double CalculateSum(double x, double y)
        {
            Calculator calculator = new Calculator();

            return calculator.Add(x, y);
        }
    }

}
