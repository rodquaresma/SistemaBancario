using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public Client Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, Client holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            double fee = 5.0;
            if (amount + fee < WithdrawLimit)
            {
                Balance -= amount + fee;
            }
            else
            {
                Console.WriteLine("O valor excede o limite de saque");
            }                       
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
