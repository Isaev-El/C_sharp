using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.WorkWithInterfaces10
{
    public class SimpleCalculator : ICalculatable
    {
        public double Add(double x, double y) => x + y;

        public double Subtract(double x, double y) => x - y;

        public double Multiply(double x, double y) => x * y;

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
            return x / y;
        }

        public void DisplayResult(double result)
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}
