namespace Bank
{
    abstract class Account : IDepositable
    {
        public Customer AccountHolder { get; protected set; }
        public decimal MonthlyInterestRate { get; protected set; }
        public decimal Balance {get; protected set;}
        

        public Account(Customer accHolder, decimal interestRate)
        {
            this.AccountHolder = accHolder;

            if (interestRate <= 0)
            {
                throw new System.ArgumentException("Monthly interest rate must be positive.");
            }
            this.MonthlyInterestRate = interestRate;
            this.Balance = 0;
        }

        public abstract decimal CalculateMonthlyInterest(int months);

        public void DepositMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new System.ArgumentException("Invalid amount. Deposit amount should be positive");
            }
            this.Balance += amount;
        }
    }
}
