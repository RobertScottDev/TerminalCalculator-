using System;

namespace TerminalCalculator;
using MathCalculator;
class Program
{
    static void Main()
    {
        RunCalculator();
    }

    static void RunCalculator()
    {
        Calculator calculator = new Calculator();
            while (true){

                DisplayMenu();

                double choice = calculator.GetValidNumber();
                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }

                Console.WriteLine("Please enter a number:");
                double num1 = calculator.GetValidNumber();

                Console.WriteLine("Please enter a 2nd number:");
                double num2 = calculator.GetValidNumber();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(calculator.Sum(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine(calculator.Minus(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine(calculator.Multiply(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine(calculator.Divide(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Do you wish to continue y/n");
                string answer = Console.ReadLine().ToLower();
                if (answer != "y") break;
            }
            Console.WriteLine("Thank you for using this application");
        
    }

    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("1) Add\n2) Subtract\n3) Multiply\n4) Divide");
        
    }
}


