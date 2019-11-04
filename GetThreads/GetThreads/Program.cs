using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread Manager");
            Console.WriteLine();
            Console.WriteLine("1. Show current threads");
            Console.WriteLine("2. List all the threads");


            string userinput = Console.ReadLine();
            if (userinput == "1")
            {
                getThreads();
            }
            else if (userinput == "2")
            {
                getListofThreads();
            }
            Console.ReadLine();
        }

        public static void getThreads()
        {

            Process thisProc = Process.GetCurrentProcess();
            ProcessThreadCollection myThreads = thisProc.Threads;
            foreach (ProcessThread pt in myThreads)
            {
                DateTime startTime = pt.StartTime;
                TimeSpan cpuTime = pt.TotalProcessorTime;
                int priority = pt.BasePriority;
                ThreadState ts = pt.ThreadState;
                Console.WriteLine("thread: {0}", pt.Id);
                Console.WriteLine(" started: {0}", startTime.ToString());
                Console.WriteLine(" CPU time: {0}", cpuTime);
                Console.WriteLine(" priority: {0}", priority);
                Console.WriteLine(" thread state: {0}", ts.ToString());
            }
        }
        
        public static void getListofThreads()
        {
            Process[] allProcs = Process.GetProcesses();
            foreach (Process proc in allProcs)
            {
                ProcessThreadCollection myThreads = proc.Threads;
                Console.WriteLine("process: {0}, id: {1}", proc.ProcessName, proc.Id);
                foreach (ProcessThread pt in myThreads)
                {
                    //DateTime startTime = pt.StartTime;
                    //TimeSpan cpuTime = pt.TotalProcessorTime;
                    int priority = pt.BasePriority;
                    ThreadState ts = pt.ThreadState;

                    Console.WriteLine(" thread: {0}", pt.Id);
                    //Console.WriteLine(" started: {0}", startTime.ToString());
                    //Console.WriteLine(" CPU time: {0}", cpuTime);
                    Console.WriteLine(" priority: {0}", priority);
                    Console.WriteLine(" thread state: {0}", ts.ToString());
                }
            }
        }
    }
}
