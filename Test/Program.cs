using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            b = a;
            a = 1;
            Console.WriteLine(b);
        }
    }
}