using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Application
{
    public delegate T Information<T>(T arg1, T arg2);
    internal class CalculatorClass
    {
        public Information<double> info;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            return num1 / num2;
        }

        public event Information<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                Console.WriteLine("Remove the Delegate");
            }
        }
    }
}
