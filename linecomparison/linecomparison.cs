using System;
using System.Collections.Generic;
using System.Text;

namespace linecomparison
{
    class linecomparison
    {
        int x1, x2,x3,x4, y1, y2,y3,y4;
        public linecomparison(int x1, int x2, int y1, int y2, int x3, int x4, int y3, int y4)
        {
            Console.WriteLine("Welcome to line comparison program");
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.x3 = x3;
            this.x4 = x4;
            this.y3 = y3;
            this.y4 = y4;
            Console.WriteLine("value of x1 =" + x1);
            Console.WriteLine("value of x2 =" + x2);
            Console.WriteLine("value of x3 =" + x3);
            Console.WriteLine("value of x4 =" + x4);
            Console.WriteLine("value of y1 =" + y1);
            Console.WriteLine("value of y2 =" + y2);
            Console.WriteLine("value of y3 =" + y3);
            Console.WriteLine("value of y4 =" + y4);
            double lengthofline1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length of line one is:" + lengthofline1);
            double lengthofline2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("length of line two is :" + lengthofline2);
            if (lengthofline1 == lengthofline2)
            {
                Console.WriteLine("Both lines are equal");
            }
            else if (lengthofline1 > lengthofline2)
            {
                Console.WriteLine("length of first line is greater than second line");
            }
            else
            {
                Console.WriteLine("lines are not equal and length of first line is less than second line");
            }
        }
    }
}
