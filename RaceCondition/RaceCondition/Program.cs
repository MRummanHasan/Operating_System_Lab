using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaceCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            Thread t = new Thread(c.Divide);
            t.Start(); //Thread 't' execute this method
            c.Divide(); //
            Console.WriteLine("Successfully Synchronized");
            Console.ReadLine();
        }
    }
    class Calc
    {
        /*Mutex m = new Mutex();*/
        object myLock = new object();
        int num1;
        int num2;
        Random rand = new Random();

        public void Divide()
        {
            for (int i = 0; i < 100000; i++)
            {
                /* // MUTEX CODE
                //Critical section
                //thread is safe
                //m.WaitOne();                
                num1 = rand.Next(1, 3);
                num2 = rand.Next(1, 3);
                int res = num1 / num2;
                num1 = 0;
                num2 = 0;
                */


                /*// LOCK CODE
                //myLock = 0;
                lock (myLock)
                {
                    //Critical section
                    //thread is safe
                    num1 = rand.Next(1, 3);
                    num2 = rand.Next(1, 3);
                    int res = num1 / num2;
                    num1 = 0;
                    num2 = 0;
                }
                */

                // MONITOR CODE
                Monitor.Enter(myLock);
                try
                {
                    //Critical section
                    //thread is safe
                    num1 = rand.Next(1, 3);
                    num2 = rand.Next(1, 3);
                    int res = num1 / num2;
                    num1 = 0;
                    num2 = 0;
                }
                catch(Exception)
                {
                    throw;
                }
                finally
                {
                    Monitor.Exit(myLock);
                }
                
            }
        }
    }
}
