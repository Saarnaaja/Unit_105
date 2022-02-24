using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(new Logger());
            calculator.AdditionMethod();
            Console.ReadLine();
        }
    }
}
