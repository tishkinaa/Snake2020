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
            Console.SetBufferSize(120, 30); //устанавливает размер окна, и убирает возможность перемотки


            HorizontalLine upLine = new HorizontalLine(0, 118, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 118, 29, '+');
            VerticalLine leftLine = new VerticalLine(0, 29, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 29, 118, '+');

            leftLine.Drow();
            rightLine.Drow();
            upLine.Drow();
            downLine.Drow();
            Console.ReadLine();
        }
    }
}
