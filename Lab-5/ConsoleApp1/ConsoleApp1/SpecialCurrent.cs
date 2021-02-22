using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SpecialCurrent : Account
    {
        readonly int openingBalance;
        readonly int Min_balance;

        public SpecialCurrent(string name, string id, int balance)
            : base(name, id, balance)
        {
            this.openingBalance = balance;
            this.Min_balance = (int)(openingBalance / 100) * 10;
        }
        public override void Transfer(int amount, Account acc)
        {
            if ((Balance - amount) >= Min_balance && amount > 0)
            {
                Balance -= amount;
                Console.WriteLine("Success....Current Balance : " + Balance);
            }
            else
            {
                Console.WriteLine("Fail....");
            }
        }
    }
}