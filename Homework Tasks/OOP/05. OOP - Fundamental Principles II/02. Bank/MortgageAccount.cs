namespace Bank
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer accountHolder, decimal interest)
            : base(accountHolder, interest)
        { }

        public override decimal CalculateMonthlyInterest(int months)
        {
            if (months <= 0)
            {
                throw new System.ArgumentException("Invalid number of months. Number of months should be > 0");
            }

            if (this.AccountHolder is Individual)
            {
                decimal interest = (months - 6) * this.Balance * this.MonthlyInterestRate / 100;
                return CheckInterestAmount(interest);
            }
            else
            {
                if (months <= 12)
                {
                    return months * this.Balance * this.MonthlyInterestRate / 100 / 2;
                }
                else
                {
                    return (12 * this.Balance * this.MonthlyInterestRate / 100 / 2) +
                        (months - 12) * this.Balance * this.MonthlyInterestRate / 100;
                }
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
