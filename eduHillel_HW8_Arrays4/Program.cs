//4.Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран: а) максимальний елемент масиву; б) мінімальний елемент масиву; в) координати мінімального елемента масиву. г) координати максимального елемента масиву.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace eduHillel_HW8_Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            int row;
            int column;
            int[,] array = new int[5, 5];
            int minRow = 0;
            int maxRow = 0;
            int minColumn = 0;
            int maxColumn = 0;
            int min = array[0, 0];
            int max = array[0, 0];


            Random random = new Random();
            for (row = 0; row < 5; row++)
            {
                for (column = 0; column < 5; column++)
                {
                    array[row, column] = random.Next(-123, 123);
                }
            }
            Console.WriteLine("Array:");
            for (row = 0; row < 5; row++)
            {
                for (column = 0; column < 5; column++)
                {
                    Console.Write(array[row, column] + " ");
                }
                Console.WriteLine();
            }
            
            for (row = 0; row < 5; row++)
            {
                for (column = 0; column < 5; column++)
                {
                    if (array[row, column] > max)
                    {
                        max = array[row, column];
                        maxRow = row;
                        maxColumn = column;
                    }
                    if (array[row, column] < min)
                    {
                        min = array[row, column];
                        minRow = row;
                        minColumn = column;
                    }
                }
            }
            Console.WriteLine($"Max element: {max}");
            Console.WriteLine($"Min element: {min}");
            Console.WriteLine($"Min element coordinates: {minRow}, {minColumn}");
            Console.WriteLine($"Max element coordinates: {maxRow}, {maxColumn}");
        }
    }
}