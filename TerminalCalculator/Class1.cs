using System;

namespace MathCalculator
{
    public class Calculator
    {
        public void Sum()
        {
            int num1, num2, answer;
            Console.WriteLine("First Add");
            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Another one");
            num2 = Convert.ToInt32(Console.ReadLine());

            answer = num1 + num2;

            Console.WriteLine($"The sum is {answer}");
            Console.ReadLine();
        }
        public void Minus()
        {
            int num1, num2, answer;

            Console.WriteLine("Now Subtract");
            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Another one");
            num2 = Convert.ToInt32(Console.ReadLine());

            answer = num1 - num2;

            Console.WriteLine($"The Differnce is {answer}");
            Console.ReadLine();
        }
        public void Multiply()
        {
            int num1, num2, answer;
            Console.WriteLine("Now Multiply");
            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Another one");
            num2 = Convert.ToInt32(Console.ReadLine());

            answer = num1 * num2;

            Console.WriteLine($"The answer is {answer}");
            Console.ReadLine();
        }
        public void Divide()
        {
            int num1, num2, answer;
            Console.WriteLine("Now Divide");
            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Another one");
            num2 = Convert.ToInt32(Console.ReadLine());

            answer = num1 / num2;

            Console.WriteLine($"The answer is {answer}");
            Console.ReadLine();
        }
    }
}







