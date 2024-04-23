using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            bool result = IsPrime(input);
            if (result)
            {
                Console.WriteLine("{0} is a primeNumber", input);
            }
            else
            {
                Console.WriteLine("{0} is a not primeNumber", input);
            }








            Console.ReadLine();
        }
        static bool IsPrime(int n)
        {
            int counter = 0;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    counter++;
                    break;
                }
            }
            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
