using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theater_arragement
{
    internal class Program
    {
        static void Main(string[] args)
        {

         
            
                // Define the size of the theater (rows and columns)
                int rows = 7;
                int columns = 10;

                // Create a 2D array to represent the theater arrangement
                char[,] theater = new char[rows, columns];

                // Initialize the theater arrangement
                InitializeTheater(theater);

                // Display the theater arrangement
                DisplayTheater(theater);
            }

            static void InitializeTheater(char[,] theater)
            {
                // Fill the theater with empty seats initially
                for (int i = 0; i < theater.GetLength(0); i++)
                {
                    for (int j = 0; j < theater.GetLength(1); j++)
                    {
                        theater[i, j] = 'O'; // 'O' represents an empty seat
                    }
                }

                // Let's mark some seats as occupied for demonstration purposes
                theater[0, 2] = 'X'; // 'X' represents an occupied seat
                theater[1, 5] = 'X';
                theater[3, 1] = 'X';
                theater[5, 8] = 'X';
            }

            static void DisplayTheater(char[,] theater)
            {
                Console.WriteLine("Theater Arrangement:");
                for (int i = 0; i < theater.GetLength(0); i++)
                {
                    for (int j = 0; j < theater.GetLength(1); j++)
                    {
                        Console.Write(theater[i, j] + " ");
                    }
                    Console.WriteLine();
                Console.ReadLine();
                }
            }
        }



    }


