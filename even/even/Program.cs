using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;

            Console.Write("\n\n");
            Console.Write("Calculate n terms of even natural number \n");
            Console.Write("---------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe even numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i);
                sum += 2 * i;
            }
           
        }
    }
}
   

