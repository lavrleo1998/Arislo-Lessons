using System;
using System.Collections.Generic;
using System.IO;//
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristo_lesson
{
    class Project
    {
        static void Main(string[] args)
        {            
            bool finish = false;
            while (finish == false)
            {
                Console.Clear();
                string a;
                Console.WriteLine(" finish, sort, paint, text");
                a = Console.ReadLine();
                if (a == "finish") finish = true;
                if (a == "sort") Sortirovka();
                if (a == "paint") Painter();
                if (a == "text") Text();
            }            
        }
        static void Sortirovka() 
        {
            List<int> Number = new List<int> { };
            Console.WriteLine("Начало сортировки, нажмите на Enter");
            Console.ReadLine();
            int rt = 0;
            int wg = 0;
            int kt = 0;
            for (int i = 0; i < 100; i++)
            {
                Random n = new Random();
                int a = n.Next(0, 100);
                for (int ii = 0; ii < i; ++ii)
                {
                    if (a == Number[ii])
                    {
                        a = n.Next(0, 100);
                        ii = -1;
                        wg++;
                    }
                    else rt++;
                }
                Number.Add(a);
                Console.WriteLine(i + ": " + Number[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Нажмите на Enter");
            Console.ReadLine();
            while (rt != 100 && wg != 0)
            {
                rt = 0;
                wg = 0;
                for (int i = 0; i < 99; i++)
                {
                    if (Number[i] < Number[i + 1]) rt++;
                    if (Number[i] == Number[i + 1]) kt++;
                    if (Number[i] > Number[i + 1])
                    {
                        wg++;
                        int a;
                        a = Number[i + 1];
                        Number[i + 1] = Number[i];
                        Number[i] = a;
                    }
                }
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + ": " + Number[i] + " ");
            }
            Console.WriteLine("Cортировка окончена, нажмите на Enter");
            Console.ReadLine();
        }
        static void Painter()
        {
            Console.WriteLine("end,*");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" 0");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" 1");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" 2");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" 3");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" 4");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" 5");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" 6");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" 7");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" 8");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 9\n");
            Console.ResetColor();
            string a;
            bool end = false;
            while (end == false)
            {
                List<int> drowing = new List<int>();                              
                a = Console.ReadLine();
                if (a == "end") end = true;
                else
                {
                    for (int i = 0; i < a.Length; i++)
                        {
                            string s = a.Substring(i, 1);
                            if (drowing.Count!=a.Length) drowing.Add(Convert.ToInt32(s));
                            else drowing[i] = Convert.ToInt32(s);
                        }
                        for (int i = 0; i < drowing.Count; i++)
                        {
                            ColorChose(drowing[i]);
                            Console.Write("  ");
                        }                    
                    Console.ResetColor();
                }
            }            
            Console.ResetColor();
            Console.ReadLine();
    }
        static void ColorChose(int number)
        {
            if (number == 0) Console.BackgroundColor = ConsoleColor.Black;
            if (number == 1) Console.BackgroundColor = ConsoleColor.DarkBlue;
            if (number == 2) Console.BackgroundColor = ConsoleColor.Green;
            if (number == 3) Console.BackgroundColor = ConsoleColor.DarkRed;
            if (number == 4) Console.BackgroundColor = ConsoleColor.DarkMagenta;
            if (number == 5) Console.BackgroundColor = ConsoleColor.DarkYellow;
            if (number == 6) Console.BackgroundColor = ConsoleColor.Gray;
            if (number == 7) Console.BackgroundColor = ConsoleColor.DarkGray;
            if (number == 8) Console.BackgroundColor = ConsoleColor.Blue;
            if (number == 9) Console.BackgroundColor = ConsoleColor.White;
        }
        static void Text()
        {
            bool end = false;
            while (end == false)
            {                
                
                
                Console.WriteLine("end, add, new, read, json");
                string a;
                a =Console.ReadLine();
                if (a == "end") end = true;                       
                if (a == "add" || a == "new")
                    {
                        bool n;
                        if (a == "add") n = true;
                        else n = false;
                        a = Console.ReadLine();
                        StreamWriter sw = new StreamWriter("t.txt",n);                        
                        sw.WriteLine(a);
                        sw.Flush();
                        sw.Close();
                    } 
                if (a == "read")
                    {
                        StreamReader sr = new StreamReader("t.txt");                        
                        Console.WriteLine(sr.ReadToEnd());
                        sr.Close();
                    }
                if (a == "j")
                    {

                    }                
                if (a == "json")
                {
                    bool end2 = false;
                    while (end2 == false)
                    {
                        Console.WriteLine("end, write, read");
                        a = Console.ReadLine();
                        if (a == "end") end = true;
                        if (a == "read")
                        {
                            StreamReader sr = new StreamReader("jsonby.txt");
                            Console.WriteLine(sr.ReadToEnd());
                            sr.Close();
                        }
                        if (a == "write")
                        {
                            Console.WriteLine("string, int,  bool");                            
                            string name= Console.ReadLine();
                            string age = Console.ReadLine();
                            a = Console.ReadLine();
                            string gender;
                            if (a == "true") gender = "Мужской";
                            else gender = "Женский";
                            name = "\"Name\":\""+name+"\",";
                            age = "\"Age\":\"" + age + "\",";
                            gender = "\"Gender\":\"" + gender + "\"";
                            StreamWriter sw = new StreamWriter("jsonby.txt",false);
                            a ="{"+name+age+gender+"}";
                            sw.WriteLine(a);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                }
            }
        }

    }
}
