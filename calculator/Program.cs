using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operation;
            double result = 0;

            Console.WriteLine("Simple Calculator in C#");
            Console.WriteLine("-----------------------\n");
            try
            {
                Console.Write("Enter first number:\n\t ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): \n\t");
                operation = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter second number:\n\t ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator entered.");
                        return;
                }

                Console.WriteLine($"Result: {num1} {operation} {num2}\n\t = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("you can't enter character value \n so please enter valid number" + ex.Message);
               
            }




            Console.ReadLine();
        }
    }
}
