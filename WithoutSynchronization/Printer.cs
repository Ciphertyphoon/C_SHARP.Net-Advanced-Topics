using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WithoutSynchronization
{
    class Printer
    {
        public void PrintTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(i);
            }
        }
    }
}
