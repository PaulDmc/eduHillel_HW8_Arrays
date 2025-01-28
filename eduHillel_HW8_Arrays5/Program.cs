//5.За допомогою enum створити програму, що буде запитувати у користувача кількість днів, а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace eduHillel_HW8_Arrays5
{
    class Program
    {
        enum DayOfWeek
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }

        static void Main(string[] args) 
        {

            Console.WriteLine("Enter the number of days:");
            int findDay;

            while (!int.TryParse(Console.ReadLine(), out findDay) || findDay < 0)
            {
                Console.WriteLine("Enter a valid number.");
            }

            DayOfWeek startingDay = DayOfWeek.Sunday;
            DayOfWeek resultDay = (DayOfWeek)(((int)startingDay + findDay - 1) % 7 + 1);
            Console.WriteLine($"In {findDay} days it will be: {resultDay}");
        }


    }
    
}