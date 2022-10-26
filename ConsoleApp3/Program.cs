using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    internal class Program
    {
       static void Main(string[] args)
        {
            SetWindowSize(WindowWidth, 71);
            SetWindowSize(WindowHeight, 71);
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Clear();
            Title = "123";
            int height = WindowHeight;
            int width = WindowWidth;
            WriteLine($"высота {height}, ширина {width}");
            string a;
            int b;
            Write("Как тебя зовут? ");
            a = Convert.ToString(ReadLine());
            Write("Сколько тебе лет? ");
            b = Convert.ToInt32(ReadLine());
            int c = DateTime.Today.Year;
            WriteLine($"{a}, ты родился в {c - b}  году");
            ReadKey();
            
        }
    }
}
