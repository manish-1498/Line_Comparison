using System;

namespace linecomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //first parameter is x1 then x2 then y1 then y2 
            linecomparison Line1 = new linecomparison(1,3,5,7);
            double Length1 = Line1.Linecomp();
            Console.WriteLine("length of line 1 ="+Length1);
            linecomparison Line2  = new linecomparison(2,3,4,5);
            double Length2 = Line2.Linecomp();
            Console.WriteLine("length of line 2 =" + Length2);
            Console.WriteLine("----------------------------");
            if (Length1 == Length2)
                Console.WriteLine("Result--Both lines are equal");
            else
                Console.WriteLine("Result--lines are unequal");
        }
    }
}
