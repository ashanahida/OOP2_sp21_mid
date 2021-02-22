using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fixed : Account
    {
        private int TenurYear;
        private int accountAge;

        public override int AccountAge
        {
            set { this.accountAge = value; }
        }

        public Fixed(string Name, string Id, int Balance, int TenurYear)

            : base(Name, Id, Balance)
        {
            this.TenurYear = TenurYear;

            this.accountAge = 0;
        }

        public override void Transfer(int amount, Account acc)
        {

            if (TenurYear <= accountAge && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Successfull .... Current Balance : " + Balance);
            }

            else
            {
                Console.WriteLine("Fail....");
            }
        }
    }
}

