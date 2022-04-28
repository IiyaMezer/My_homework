using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class HW1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя:");
            string Name = Console.ReadLine();
            DateTime currDate = DateTime.Now;

            Console.WriteLine($"Здравствуйте, {Name}, сегодня {currDate} ");

            Console.WriteLine("Press ENTER to finish programm");
            Console.ReadLine();
        }
    }
}
