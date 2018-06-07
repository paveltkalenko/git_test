using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_test
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int c = Sum(2, 1);
            Console.WriteLine($"{c}");
        }
    }
}
