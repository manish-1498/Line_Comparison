using System;

namespace linecomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison program");
            /*first parameter is x1 then x2 then y1 then y2 
             * then x3 then x4 then y3 then y4*/
            linecomparison line = new linecomparison(1,3,5,7,1,1,1,1);
        }
    }
}
