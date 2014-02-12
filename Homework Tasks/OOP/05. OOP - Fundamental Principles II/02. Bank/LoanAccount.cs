namespace Bank
{
    class LoanAccount : Account
    {
        public LoanAccount(Customer accountHolder, decimal interestRate)
            : base(accountHolder, interestRate)
        { }

        public override decimal CalculateMonthlyInterest(int months)
        {
            if (months <= 0)
            {
                throw new System.ArgumentException("Invalid number of months. Number of months should be > 0");
            }

            if (this.AccountHolder is Individual)
            {
                decimal interest =  (months - 3) * this.Balance * this.MonthlyInterestRate / 100;
                return CheckInterestAmount(interest);
            }
            else
            {
                 decimal interest =  (months - 2) * this.Balance * this.MonthlyInterestRate / 100;
                 return CheckInterestAmount(interest);
            }
        }

        private static decimal CheckInterestAmount(decimal interest)
        {
            if (interest <= 0)
            {
                return 0;
            }
            else
            {
                return interest;
            }
        }
    }
}
