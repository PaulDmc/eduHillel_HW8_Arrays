//3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення (у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ..., в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace eduHillel_HW8_Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            int row;
            int column;

            int[,] table = new int[9, 9];
            for (row = 0; row < 9; row++)
            {
                for (column = 0; column < 9; column++)
                {
                    table[row, column] = (row + 1) * (column + 1);
                }
            }

            Console.WriteLine("Multiplication table:");
            for (row = 0; row < 9; row++)
            {
                for (column = 0; column < 9; column++)
                {
                    Console.Write(table[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}