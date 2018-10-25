using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventGyak
{
    class Program
    {
        static void Main(string[] args)
        {
            bool first = true;
            Task.Run(() => alma());
            do
            {
                if (!first)
                    Console.WriteLine("beirt");
                else
                    first = false;



            } while (!(Console.ReadKey().KeyChar == 'e'));
        }

        static void alma()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("bent"+i);
            }

            //return beka;
        }
    }
}
