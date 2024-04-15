using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Division_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("please inter a numaretor");
            int numaretor = int.Parse(Console.ReadLine());
            Console.WriteLine("please inter a denomenator");
            int denomenator = int.Parse(Console.ReadLine());
            Division(numaretor, denomenator);

            Console.WriteLine("thank you");
            Console.ReadLine();

        }

       static void Division(int n,int d)
        {
            try
            {
                var result = n / d;
                Console.WriteLine($"Division Result is : {result}");

            }
            catch(Exception ex)
            {
                Console.WriteLine("you can't get divisible by zero");
            }



        }
    }
}
