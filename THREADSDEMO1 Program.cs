using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THREADSDEMO1
{
    class Test
    {
        static void test1()
        {
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine("test1 is :" + i);
            }
        }

        static void test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("test2 is :" + i);
              /*  if (i == 50)
                {
                    Test.Sleep(2000);
                }*/
            }
        }
        static void test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("test3 is :" + i);
            }
        }
        static void Main(string[] args)
        {
             test1();
             test2();
             test3();
           
            Console.ReadLine();
        }
    }
}
