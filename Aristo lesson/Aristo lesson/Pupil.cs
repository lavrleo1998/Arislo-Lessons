using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristo_lesson
{
    class Pupil
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Сlassroom { get; set; }

        public Pupil (string n, string s, string c)
        {
            this.Name = n;
            this.Surname = s;
            this.Сlassroom = c;
        }

        public void Homework(string answer)
        {
            if (answer == "yes")
            {
                Console.WriteLine("Молодец!");
            }
            else
            {
                Console.WriteLine("Молодец, два!");
            }
        }
    }
}
