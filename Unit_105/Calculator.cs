using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_105
{
    internal class Calculator : IAddition
    {
        private ILogger _logger;
        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public void AdditionMethod()
        {
            try
            {
                var first = InputValue("Введите первое число");
                var second = InputValue("Введите второе число");
                Addition(first, second);
            }
            catch (Exception ex)
            {
                _logger.Error($"{ex.Message}");
            }
        }

        double InputValue(string text)
        {
            Console.WriteLine(text);
            while (true)
            {
                var strValue = Console.ReadLine();
                if (double.TryParse(strValue, out double value))
                {
                    _logger.Event($"Успешное преобразование {strValue} в число {value}.");
                    return value;
                }
                _logger.Error($"{strValue} не является числом.");
            }
        }

        public double Addition(double left, double right)
        {
            var result = left + right;
            _logger.Event($"{left} + {right} = {result}");
            return result;
        }
    }
}
