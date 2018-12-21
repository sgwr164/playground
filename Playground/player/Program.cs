using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fspg;

namespace player
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Class1();
            var var = File1.plus(1, 2);

            Console.WriteLine(foo.X);
            Console.WriteLine(var.ToString());
            Console.ReadLine();
        }
    }
}
