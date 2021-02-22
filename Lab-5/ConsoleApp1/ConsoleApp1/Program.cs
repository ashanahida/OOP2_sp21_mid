using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account A1 = new Savings("NOYON", "234782", 4234423);

            A1.Transfer(50654, A1);


            Account A2 = new SpecialCurrent("ABU", "239279", 40283);

            A2.Transfer(96089, A2);


            Account A3 = new Fixed("ABDUL", "347982", 3478929, 3);

            A3.AccountAge = 3;
            A3.Transfer(344450, A3);


            Account A4 = new OverDraft("RABBI", "238272", 32838, 237927);
            A4.Transfer(49790, A4);

            Console.ReadLine();

        }
    }
}





