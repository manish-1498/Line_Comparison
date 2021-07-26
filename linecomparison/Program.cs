using System;

namespace linecomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //first parameter is x1 then x2 then y1 then y2 
            linecomparison Line1 = new linecomparison(10,23,30,40);
            double Length1 = Line1.Linecomp();
            Console.WriteLine("length of line 1 ="+Length1);
            linecomparison Line2  = new linecomparison(5,15,25,35);
            double Length2 = Line2.Linecomp();
            Console.WriteLine("length of line 2 =" + Length2);
            Console.WriteLine("----------------------------");
            if (Length1.CompareTo(Length2)==0)
                Console.WriteLine("Result--Both lines are equal");
            else if (Length1.CompareTo(Length2)>0)
            {
                Console.WriteLine("Result--length of first line is greater than second line");
            }
            else
            {
                Console.WriteLine("Result--lines are not equal and length of first line is less than second line");
            }
        }
    }
}
