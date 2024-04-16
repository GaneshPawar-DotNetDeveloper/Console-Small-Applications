using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace user_get_full_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your First Name :");
            String FirstName=Console.ReadLine();
            Console.WriteLine("Please Enter Your Last Name:");
            String LastName=Console.ReadLine();
            string FullName = $"FullName is : {FirstName} {LastName}";
            Console.WriteLine(FullName);
            Console.ReadLine();
        }
    }
}
