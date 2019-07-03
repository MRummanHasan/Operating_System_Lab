using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                Console.WriteLine(args[0] + "-" + args[1]);
              

            }
            Console.ReadKey();
        }
    }
}
