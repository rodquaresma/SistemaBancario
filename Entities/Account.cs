using System;

namespace Sistema_Bancario.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
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
            if (amount > WithdrawLimit + fee)
            {
                throw new Exception("O valor excede o limite de saque");
            }                       
            if (amount < Balance)
            {
                throw new Exception("O valor excede o saldo");
            }
            Balance -= amount;
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
