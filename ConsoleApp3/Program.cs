using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = 4;

            Console.WriteLine($"День недели: {GetDayName(dayNumber)}");
            Console.ReadKey();
        }
        public static string GetDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресенье";
                default:
                    return "Неверный номер дня";
            }
        }
    }
}
