using System;

namespace Sistema_Bancario.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount(int number, Client holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void LoanFaster(double amount)
        {
            if (amount > LoanLimit)
            {
                throw new Exception("O valor excede o limite de empréstimo");
            }
            Balance -= amount;
        }
    }
}
