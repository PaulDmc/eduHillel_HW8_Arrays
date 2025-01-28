//1.Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random. Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace eduHillel_HW8_Arrays
{
    public static class Program

    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 11);
            }

            Console.WriteLine("Масив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }

            Console.WriteLine("Elements with pair index:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Index {i}: {numbers[i]}");
                }
            }
        }
    }
}