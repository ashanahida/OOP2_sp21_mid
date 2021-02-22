using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Account
    {
        private string Name,Id;
        protected int Balance;
        public Account() { }
        public Account(string name, string id, int balance)

        {
            this.Name = name;

            this.Id = id;

            this.Balance = balance;
        }

        abstract public void Transfer(int amount, Account acc);

        virtual public int AccountAge { get; set; }
    }
}




