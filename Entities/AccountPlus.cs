namespace Sistema_Bancario.Entities
{
    internal class AccountPlus : Account
    {
        public double LoanLimit = 1000.00;

        public AccountPlus(int number, Client holder, double balance, double loanLimit) : base (number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount > LoanLimit)
            {
                throw new Exception("O valor excede o limite de empréstimo");
            }
            Balance += amount;
        }

        public override void Withdraw(double amount)
        {
            if (amount < Balance)
            {
                throw new Exception("O valor excede o saldo");
            }
            Balance -= amount;
        }
    }
}
