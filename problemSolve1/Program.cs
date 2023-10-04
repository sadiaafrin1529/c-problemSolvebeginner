using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolve1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Alexandra Abramov";
            Console.WriteLine("Hello:" + name );

            Console.Write("first Number:");
            int numberOne =Convert.ToInt32 (Console.ReadLine());
            Console.Write("first Number:");
            double numberTwo= Convert.ToDouble(Console.ReadLine());
            double sum = numberOne + numberTwo;
            Console.WriteLine("Sum: " + sum);


            Console.ReadKey();


        }
        
    }
}
