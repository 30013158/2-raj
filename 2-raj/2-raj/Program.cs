using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_raj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter your lucky number here");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            int num2 = int.Parse(Console.ReadLine());
            double result1 = num1 + num2;
            double result2 = num1 * num2;
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
