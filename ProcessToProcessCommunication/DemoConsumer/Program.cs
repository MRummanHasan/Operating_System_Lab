using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Users\glab.KIETNN\Documents\Visual Studio 2012\Projects\DemoArguments\bin\Debug";
            ps.Arguments = "Hello World";

            Process p = Process.Start(ps);
            p.StartInfo.RedirectStandardOutput = true;
            string output = p.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            //p.WaitForExit();

        }
    }
}
