using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace THREADSDEMO
{

    class Thread
    {


         public void Thread1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread1 is:" + i);
             
            }
        }

        public void Thread2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread2 is:" + i);
            }
        }

        public void Thread3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread3 is:" + i);
            }
        }


        static void Main(String[] args)
        {
            Thread t1 = new Thread();
            Thread t2 = new Thread();
            Thread t3 = new Thread();
            t1.Thread1();
            t2.Thread2();
            t3.Thread3();

           /* Thread t = Thread.CurrentThread;
            t.Name = "ThreadDemo";
            Console.WriteLine("My current executed thread is:" + Thread.CurrentThread);*/
            Console.ReadLine();
        }
   }
}
