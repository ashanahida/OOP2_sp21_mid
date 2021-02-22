using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OverDraft : Account
        {
            private int limit;

            public OverDraft(string name, string id, int balance, int limit)
                : base(name, id, balance)
            {
                this.limit = limit;
            }

            public override void Transfer(int amount, Account acc)
            {
                if ((Balance + limit) >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine("Success.... Current Balance : " + Balance);
                }
                else
                {
                    Console.WriteLine("Fail.....");
                }
            }
        }
    }



