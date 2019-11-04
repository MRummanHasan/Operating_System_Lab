using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetProc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task Manager");
            Console.WriteLine();
            Console.WriteLine("1. Show current process");
            Console.WriteLine("2. List all the processes");
            

            string userinput = Console.ReadLine();
            if (userinput == "1")
            {
                getProcess();
            }
            else if (userinput == "2")
            {
                getListofProcesses();    
            }
            Console.ReadLine();
        }


        public static void getProcess()
        {
            Process thisProc = Process.GetCurrentProcess();
            string procName = thisProc.ProcessName;
            DateTime started = thisProc.StartTime;
            int procID = thisProc.Id;
            int memory = thisProc.VirtualMemorySize;
            int priMemory = thisProc.PrivateMemorySize;
            int physMemory = thisProc.WorkingSet;
            int priority = thisProc.BasePriority;
            ProcessPriorityClass priClass = thisProc.PriorityClass;
            TimeSpan cpuTime = thisProc.TotalProcessorTime;
            Console.WriteLine("Process: {0}, ID: {1}", procName, procID);
            Console.WriteLine(" started: {0}", started.ToString());
            Console.WriteLine(" CPU time: {0}", cpuTime.ToString());
            Console.WriteLine(
            " priority class: {0} priority: {1}", priClass, priority);
            Console.WriteLine(" virtual memory: {0}", memory);
            Console.WriteLine(" private memory: {0}", priMemory);
            Console.WriteLine(" physical memory: {0}", physMemory);
            Console.WriteLine("\n trying to change priority...");
            thisProc.PriorityClass = ProcessPriorityClass.High;
            priClass = thisProc.PriorityClass;
            Console.WriteLine(" new priority class: {0}", priClass);


        }

        public static void getListofProcesses()
        {
            int totMemory = 0;
            Console.WriteLine("Info for all processes:");
            Process[] allProcs = Process.GetProcesses();
            foreach (Process thisProc in allProcs)
            {
                string procName = thisProc.ProcessName;
                //DateTime started = thisProc.StartTime;
                int procID = thisProc.Id;
                int memory = thisProc.VirtualMemorySize;
                int priMemory = thisProc.PrivateMemorySize;
                int physMemory = thisProc.WorkingSet;
                totMemory += physMemory;
                int priority = thisProc.BasePriority;
                ////TimeSpan cpuTime = thisProc.TotalProcessorTime;
                Console.WriteLine("Process: {0}, ID: {1}", procName, procID);
                //Console.WriteLine(" started: {0}", started.ToString());
                //Console.WriteLine(" CPU time: {0}", cpuTime.ToString());
                Console.WriteLine(" virtual memory: {0}", memory);
                Console.WriteLine(" private memory: {0}", priMemory);
                Console.WriteLine(" physical memory: {0}", physMemory);
            }
            Console.WriteLine("\nTotal physical memory used: {0}", totMemory);
        }

    }
}