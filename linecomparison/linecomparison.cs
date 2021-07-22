using System;
using System.Collections.Generic;
using System.Text;

namespace linecomparison
{
    class linecomparison
    {
        int x1, x2, y1, y2;
        public linecomparison(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public double Linecomp()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("value of x1 =" + x1);
            Console.WriteLine("value of x2 =" + x2);
            Console.WriteLine("value of y1 =" + y1);
            Console.WriteLine("value of y2 =" + y2);
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return length;
        }
    }
}