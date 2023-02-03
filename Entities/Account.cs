using System;
using System.Text;
using System.Globalization;

namespace Sistema_Bancario.Entities
{
    internal class Account
    {
        public string Id = "10100-1";
        public Client client;
        public double Balance { get; set; }
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome: " + client.Name);
            sb.AppendLine("Conta: " + Id);
            sb.AppendLine("Saldo: " + Balance.ToString("F2", CultureInfo.InvariantCulture));            
            return sb.ToString();
        }

    }
}
