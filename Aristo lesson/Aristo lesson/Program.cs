using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristo_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new Pupil("Иван", "Иванов","9А");
            Pupil pupil2 = new Pupil("Макар", "Макаров", "9А");
            Pupil pupil3 = new Pupil("Петр", "Петров", "9А");
            Pupil pupil4 = new Pupil("Василий", "Петров", "9А");

            Console.WriteLine("Выберите ученика");
            Console.WriteLine("1)" + pupil1.Name + " " + pupil1.Surname);
            Console.WriteLine("2)" + pupil2.Name + " " + pupil2.Surname);
            Console.WriteLine("3)" + pupil3.Name + " " + pupil3.Surname);

            int who = Convert.ToInt32(Console.ReadLine());
            if (who == 1)
            {
                Console.WriteLine("Ты сделал домашнее задание?");
                pupil1.Homework(Console.ReadLine());
            }
            if (who == 2)
            {
                Console.WriteLine("Ты сделал домашнее задание?");
                pupil2.Homework(Console.ReadLine());
            }
            if (who == 3)
            {
                Console.WriteLine("Ты сделал домашнее задание?");
                pupil3.Homework(Console.ReadLine());
            }
            
            Console.ReadLine();
        }
    }
}
