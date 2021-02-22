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
            int i;

            Console.Write("\n\n");
            Console.Write("Calculate n terms of even number \n");
            Console.Write("\n\n");
           
            Console.Write("\nThe even numbers are :");
            for (i = 1; i <=10 ; i++)
            {
                Console.Write("{0} ", 2 * i);
            }
           
        }
    }
}
   

