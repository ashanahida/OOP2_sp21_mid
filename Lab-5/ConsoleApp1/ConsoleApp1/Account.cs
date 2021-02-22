using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Account
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int? accNo;

        public int? AccNo
        {
            get { return (int)accNo; }
            set { accNo = value; }
        }


        protected double? Balance { get; set; }

        protected int numOfTransaction { get; set; }
        protected int MaxNumOfTransaction { get; set; }

        public Account()
        {
            this.name = null;
            this.Balance = null;
            this.accNo = null;
        }

        protected Account(string name, int? accNo, object balance)
        {
            this.name = name;
            this.accNo = accNo;
            this.Balance = Balance;
        }

        abstract public void Withdraw(double amount);
    }
}


