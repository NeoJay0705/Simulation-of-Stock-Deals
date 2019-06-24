using PersonalLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuntionTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Name a = new Name();
            Name b = new Name();
            List<Name> aa = new List<Name>();
            a.NameCall = 1;
            b.NameCall = 2;
            aa.RemoveAt(1);
            Console.WriteLine(aa[1].NameCall);
        }
    }
}