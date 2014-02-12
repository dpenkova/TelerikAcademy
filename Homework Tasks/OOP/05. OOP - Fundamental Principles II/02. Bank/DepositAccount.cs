using System;

namespace Bank
{
    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer accHolder, decimal interest)
            : base(accHolder, interest)
        { 
        }

        public override decimal CalculateMonthlyInterest(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentException("Invalid number of months. Number of months should be > 0");
            }

            if (this.Balance > 1000)
            {
                return months * this.Balance * this.MonthlyInterestRate / 100;
            }
            else return 0;
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentOutOfRangeException(String.Format("Withdraw amount can not exceed the account balance: {0}", this.Balance));
            }
            if (amount <= 0)
            {
                throw new ArgumentNullException("Cannot withdraw negative or zero amount.");
            }

            this.Balance -= amount;
        }
    }
}
