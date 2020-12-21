using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Ordering
{
    class Mythreads
    {
        Semaphore sem1 = new Semaphore(0, 1);
        Semaphore sem2 = new Semaphore(0, 1);
        public void Thread1()
        {
            Console.WriteLine("Thread1 accurates before Thread2");

            sem1.Release();
        }

        public void Thread2()
        {
            sem1.WaitOne();
            Console.WriteLine("Thread2 accurates before Thread1");
            sem1.Release();
            sem2.Release();
        }

        public void Thread3()
        {
            sem2.WaitOne();
            Console.WriteLine("Thread3 accurates before Thread2");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mythreads myThread = new Mythreads();
            Thread t1 = new Thread(myThread.Thread1);
            Thread t2 = new Thread(myThread.Thread2);
            Thread t3 = new Thread(myThread.Thread3);

            t1.Start();
            t2.Start();
            t3.Start();


            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine("Main thread is existing");
            Console.ReadLine();
        }
    }
}
