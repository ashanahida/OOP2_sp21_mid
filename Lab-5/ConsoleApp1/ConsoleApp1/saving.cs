using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Savings : Account
    {
        private const int Min_balance = 430;

        public Savings(string name, string id, int balance) : base(name, id, balance) { }

        public override void Transfer(int amount, Account acc)
        {
            if ((Balance - amount) >= Min_balance && amount > 0)
            {
                Balance -= amount;
                Console.WriteLine("Success.... Current Balance : " + Balance);
            }
            else
            {
                Console.WriteLine("Fail....");
            }
        }
    }
}


