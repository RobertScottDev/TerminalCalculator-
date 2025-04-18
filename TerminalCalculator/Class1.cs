using System;

namespace MathCalculator
{
    public class Calculator
    {
        public  double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public  double Minus(double num1, double num2)
        {
            return num1 - num2;
        }
        public  double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public  double Divide(double num1, double num2)
        {
            while (num2 == 0)
            {
                Console.WriteLine("Can't divide by 0, try again");
                num2 = GetValidNumber();
                
            }
            return num1 / num2;
        }

        public  double GetValidNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Please enter a valid number");
            return number;
        }
        
    }
}







