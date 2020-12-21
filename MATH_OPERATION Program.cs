using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATH_OPERATIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            int res;
            Console.WriteLine(Math.Min(a, b));
            Console.WriteLine(Math.Max(a, b));
            Console.WriteLine(Math.DivRem(b, a, out res));
            Console.WriteLine(Math.BigMul(a, b));
           
            

            Console.ReadLine();
        }
    }
}
