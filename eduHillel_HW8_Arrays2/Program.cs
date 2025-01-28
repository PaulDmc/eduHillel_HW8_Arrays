// 2.Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число./

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace eduHillel_HW8_Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 11);
            }

            Console.WriteLine("Array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Summ of elemets: {sum}");

            if (sum >= 0)
            {
                Console.WriteLine("Summ is positive.");
            }
            else
            {
                Console.WriteLine("Summ is negative.");
            }
        }
    }
}