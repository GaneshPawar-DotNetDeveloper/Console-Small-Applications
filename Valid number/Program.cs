using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

                   Console.WriteLine("please enter your first number");
                   int first;
            if     (int.TryParse(Console.ReadLine(), out first))
            {
                   Console.WriteLine("please enter your second number");
                   int second;
                if (int.TryParse(Console.ReadLine(), out second))
                {
                    //int.TryParse(Console.ReadLine(), out second);
                    int addition = first + second;
                    string result = string.Format("{0} + {1}= {2}", first, second, addition);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("please enter second valid number");
                }
            }
            else
            {
                    Console.WriteLine("please enter first valid number");
            }

                    Console.ReadLine();
        }
    }
}

