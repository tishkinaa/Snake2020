using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw(1, 4, '*');
            Draw(4, 5, '#');
            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
