using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OSlab_threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(proA);
            t1.Name = "My Thread";
            Console.WriteLine("Before Start Thread");
            Console.WriteLine("Thread Name is = " + t1.Name);
            Console.WriteLine("Thread Live is = " + t1.IsAlive);
            Console.WriteLine("Thread Background is = " + t1.IsBackground);
            Console.WriteLine("Thread Priority is = " + t1.Priority);
            Console.WriteLine("Thread Id is = " + t1.ManagedThreadId);
            Console.WriteLine("Thread State is = " + t1.ThreadState);
            Console.WriteLine("Thread Domain is = " + Thread.GetDomain().FriendlyName);

            t1.Start();
            Console.WriteLine("\nAfter Start Thread");
            Console.WriteLine("Thread Name is = " + t1.Name);
            Console.WriteLine("Thread Live is = " + t1.IsAlive);
            Console.WriteLine("Thread Background is = " + t1.IsBackground);
            Console.WriteLine("Thread Priority is = " + t1.Priority);
            Console.WriteLine("Thread Id is = " + t1.ManagedThreadId);
            Console.WriteLine("Thread State is = " + t1.ThreadState);
            Console.WriteLine("Thread Domain is = " + Thread.GetDomain().FriendlyName);

            Console.ReadKey();
        }     

        static void proA(object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("NumA = {0}",i);
                Thread.Sleep(1000);
            }
        }
        
    }
}
