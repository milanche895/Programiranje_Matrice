using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < numbers.GetLength(0); i++) {
                Console.Write("Row" +i+ ": ");
                for (int j = 0; j < numbers.GetLength(1); j++) {
                    Console.Write(numbers[i, j] + "");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            //test
        }
    }
}
