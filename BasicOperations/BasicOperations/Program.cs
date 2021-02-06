using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int a = 10;
            Console.WriteLine("The value is " + a);
            float f = 10.56f;
            Console.WriteLine("The value of f is {0}", f);
            Console.WriteLine("The value of a is {0} and f is {1}", a, f);

            //implicit casting
            short s = 10;
            int i;
            i = s;
            //explicit casting
            int j = 20485943;
            short h;
            h = (short)j;

            int m = 4;
            short n;
            n = (short)m;

            Console.WriteLine("j={0}\nh={1}\n\nm={2}\nn={3}", j, h, m, n);

        }
    }
}
