using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_console
{
    class Program
    {
        class A
        {
            static int i;
            static A()
            {
                Console.WriteLine("Static Constructor of A has No Control. Executes before any intance is created.");
                i = 5;
            }
            public A() { Console.WriteLine("default constructor of A"); }
            public void show()
            { Console.WriteLine("value of i is : " + i); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This is main");
            A a = new A();
            a.show();
        }
    }
}
