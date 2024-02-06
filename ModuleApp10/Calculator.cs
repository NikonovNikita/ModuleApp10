using System.Runtime.CompilerServices;

namespace FinalProject
{
    internal class Calculator : ICalculator
    {
        private ILogger Logger { get; }

        internal Calculator(ILogger logger)
        {
            Logger = logger;
        }

        internal void StartProcess()
        {
            Console.WriteLine("Добро пожаловать в мини-калькулятор!\nНа ввод принимаются ДВА операнда!");
            
            var num1 = GetNum();
            var operatoR = GetOperator();
            var num2 = GetNum();

            switch(operatoR)
            {
                case "+": Logger.ShowResult(Addition(num1, num2));  break;
                case "-": Logger.ShowResult(Subtraction(num1, num2)); break;
                case "*": Logger.ShowResult(Multiplication(num1, num2)); break;
                case "/": Logger.ShowResult(Divide(num1, num2)); break;
            }
        }

        internal double GetNum()
        {
            do
            {
                try
                {
                    Console.Write("\nВведите операнд: ");
                    if (!double.TryParse(Console.ReadLine(), out var num))
                        throw new FormatException();
                    return num;
                }
                catch (Exception ex)
                {
                    Logger.ColorTheException(ex);
                }
            } while (true);
            
            
        }

        internal string GetOperator()
        {
            do
            {
                try
                {
                    Console.Write("\nВведите оператор ( +  -  *  / ) : ");
                    var input = Console.ReadLine();
                    if (input != "+" && input != "-" && input != "*" && input != "/")
                        throw new FormatException();
                    return input;
                }
                catch (Exception ex)
                {
                    Logger.ColorTheException(ex);
                }
            } while (true);
        }

        public double Addition(double value1, double value2)
        {
            Logger.Event("Началась операция сложение");
            return value1 + value2;
        }

        public double Divide(double value1, double value2)
        {
            if (value2 == 0)
                throw new DivideByZeroException("На ноль делить нельзя!");
            Logger.Event("Началась операция деление");
            return value1 / value2;
        }

        public double Multiplication(double value1, double value2)
        {
            Logger.Event("Началась операция умножение");
            return value1 * value2;
        }

        public double Subtraction(double value1, double value2)
        {
            Logger.Event("Началась операция вычитание");
            return value1 - value2;
        }
    }
}
