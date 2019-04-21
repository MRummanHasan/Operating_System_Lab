using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OSlab_priorityThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(proA);
            Thread t2 = new Thread(proB);
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.BelowNormal;
            t1.Start();
            t2.Start();

            Thread t3 = new Thread(() => passArg(5, 2));
            t3.Priority = ThreadPriority.AboveNormal;
            t3.Start();

            Console.ReadKey();
        }

        static void passArg(int p1, int p2)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("A : {0}, B : {1}", p1, p2);
            }
        }


        static void proA(object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("NumA = {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void proB(object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("NumB = {0}", i);
                Thread.Sleep(2000);
            }
        }
    }
}
