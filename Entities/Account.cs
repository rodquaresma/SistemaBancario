using System;
using System.Text;
using System.Globalization;

namespace Sistema_Bancario.Entities
{
    internal class Account
    {

        
        public string Id = "10100-1";
        public string Holder = "Rodrigo Quaresma";
        public double Balance = 1000.00;
        public double WithdrawLimit = 500.00;

        public Account()
        {
        }

        public Account(string id, double balance, double withdrawLimt)
        {
            Id = id;            
            Balance = balance;
            WithdrawLimit = withdrawLimt;
        }

        public void Withdraw(double amount)
        {
            double fee = 5.0;
            if (amount + fee > WithdrawLimit)
            {
                throw new ApplicationException("O valor excede o limite de saque");
            }                       
            if (amount + fee > Balance)
            {
                throw new ApplicationException("O valor excede o saldo");
            }
            Balance -= amount + fee;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome: " + Holder);
            sb.AppendLine("Conta: " + Id);
            sb.AppendLine("Saldo: " + Balance.ToString("F2", CultureInfo.InvariantCulture));            
            return sb.ToString();
        }

    }
}
