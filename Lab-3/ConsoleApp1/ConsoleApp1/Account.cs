using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Account
    {
        private string accName, acid;

        private int balance;
        public Account()
        {
            Console.WriteLine("empty Account Obj create.");
            balance = 0;

        }
        public void deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("deposited value is {0} & {1} is your new balance", amount, balance);

            }
            else
            {
                Console.WriteLine("INVALID...");
            }
        }

        public void withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("withdrawed value is {0}& {1} is your new Balance ", amount, balance);
            }
            else
            {
                Console.WriteLine("INVALID...");
            }
        }

        public string AccName
        {
            set
            {
                accName = value;


            }
            get
            {
                return accName;
            }
        }
            public string Acid
        {
            set
            {
                acid = value;

            }
            get
            {
                return acid;

            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
        }

        }
  }

    

