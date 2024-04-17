using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine_shopee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int RedWinesquantity = 0;
            int WhiteWinesquantity = 0;
            int RoséWinesquantity = 0;
            int SparklingWinesquantity = 0;
            int DessertWinesquantity = 0;
            int FortifiedWinesquantity = 0;
            string continuee = string.Empty;
            Console.WriteLine(" hello sir");
            Console.WriteLine("            *** welcome to our DSP Wine shopee***");
            do {
                
                Console.WriteLine("\n please select your brand");
                Console.WriteLine("press '1' For Red Wines:\n" +
                    "press '2' for White Wines:\n" +
                    "press '3' for Rosé Wines:\n" +
                    "press '4' for Sparkling Wines:\n" +
                    "press '5' for Dessert Wines:\n" +
                    "press '6' for Fortified Wines:");
                int brand;
                int quantity;
               // int items;
                if (int.TryParse(Console.ReadLine(), out brand))
                {
                    switch (brand)
                    {
                        case 1:
                            Console.WriteLine("you select red wine");
                            Console.WriteLine("how much quantity you want :");
                            quantity= Convert.ToInt32(Console.ReadLine());
                            RedWinesquantity = RedWinesquantity + quantity;
                            break;
                        case 2:
                            Console.WriteLine("you select white wine");
                            Console.WriteLine("how much quantity you want :");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            WhiteWinesquantity = WhiteWinesquantity + quantity; 
                            break;
                        case 3:
                            Console.WriteLine("you select rose wines");
                            Console.WriteLine("how much quantity you want :");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            RoséWinesquantity =RoséWinesquantity + quantity;
                            break;
                        case 4:
                            Console.WriteLine("you select sparking wines");
                            Console.WriteLine("how much quantity you want :");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            SparklingWinesquantity =SparklingWinesquantity + quantity;
                            break;
                        case 5:
                            Console.WriteLine("you select dessert wines");
                            Console.WriteLine("how much quantity you want :");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            DessertWinesquantity = DessertWinesquantity + quantity;
                            break;
                        case 6:
                            Console.WriteLine("you select fortifed wines");
                            Console.WriteLine("how much quantity you want :");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            FortifiedWinesquantity = FortifiedWinesquantity + quantity;
                            break;
                        default:
                            Console.WriteLine("you enter wrong number");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("you enter invalid format");

                }
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("do you wont continue ");
                Console.WriteLine("for continue press 'Y'or for exit please enter 'n'");
                continuee = Console.ReadLine();
            }while( continuee.ToUpper()=="Y" );
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("*****************************************8");
            int totalBill = 0;
           
            if (RedWinesquantity  > 0)
            {
                Console.WriteLine($"amount of RedWinesquantity is {RedWinesquantity}* 250 ={RedWinesquantity * 250}");
                totalBill = totalBill + RedWinesquantity*250;
            }
            if(WhiteWinesquantity>0)
            {
                Console.WriteLine($"amount of WhiteWinesquantity is {WhiteWinesquantity}* 300 ={WhiteWinesquantity*300}");
                totalBill = totalBill + WhiteWinesquantity * 300;
            }
            if (RoséWinesquantity>0)
            {
                Console.WriteLine($"amount of RoséWinesquantity is {RoséWinesquantity}* 350 ={RoséWinesquantity*350}");
                totalBill = totalBill + RoséWinesquantity * 350;
            }
            if (SparklingWinesquantity>0)
            {
                Console.WriteLine($"amount of SparklingWinesquantity is {SparklingWinesquantity}* 500 ={SparklingWinesquantity*500}");
                totalBill = totalBill + SparklingWinesquantity * 500;
            }
            if (DessertWinesquantity>0)
            {
                Console.WriteLine($"amount of DessertWinesquantity is {DessertWinesquantity}* 750 ={DessertWinesquantity*750}");
                totalBill = totalBill + DessertWinesquantity * 750;
            }
            if (FortifiedWinesquantity > 0)
            {
                Console.WriteLine($"amount of FortifiedWinesquantity is {FortifiedWinesquantity}* 1750 = {FortifiedWinesquantity*1750}");
                totalBill = totalBill + FortifiedWinesquantity * 1750;
            }
            if (totalBill > 0)
            {
                Console.WriteLine($"your total amount is {totalBill}");
            }
            double Gst = totalBill * 18 / 100;
            Console.WriteLine($"totalbill amount of Gst is := {Gst}");
            Console.WriteLine($"totalBill including all taxes is  : \n {Gst}+{totalBill} Amount is = {Gst + totalBill}");
            Console.WriteLine(" ***don't drink and drive ### \n    thank you visit again!!!!!");
            Console.ReadLine();
        }
    }
}
