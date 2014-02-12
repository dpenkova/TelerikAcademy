/*  Task 02:
    A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
Customers could be individuals or companies.
	All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit 
and withdraw money. Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
as follows: number_of_months * interest_rate.
    Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months 
if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months 
for individuals.
    Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, 
interfaces, base classes and abstract actions and implement the calculation of the interest functionality 
through overridden methods.
 */

using System;

namespace Bank
{
    class ConsoleTest
    {
        static void Main()
        {
            Customer companyX = new Company("ABS intl.", "133234231");
            Company compY = new Company("BCS intl.", "123456789");
            Individual indX = new Individual("Pesho", "89765465789");

            Console.WriteLine("\nDeposit account:");
            DepositAccount depositAcc = new DepositAccount(companyX, 0.2m);
            Console.WriteLine(depositAcc.Balance);
            depositAcc.DepositMoney(20000000);
            Console.WriteLine(depositAcc.Balance);
            depositAcc.WithdrawMoney(3000);
            Console.WriteLine(depositAcc.Balance);
            Console.WriteLine(depositAcc.CalculateMonthlyInterest(12));

            Console.WriteLine("\nLoan account Company:");
            Account loanAcc = new LoanAccount(compY, 0.3m);
            Console.WriteLine(loanAcc.Balance);
            loanAcc.DepositMoney(1000);
            Console.WriteLine(loanAcc.Balance);
            Console.WriteLine(loanAcc.CalculateMonthlyInterest(3));
            
            Console.WriteLine("\nLoan account Individual:");
            Account loanInd = new LoanAccount(indX, 0.34m);
            Console.WriteLine(loanInd.Balance);
            loanInd.DepositMoney(1000);
            Console.WriteLine(loanInd.Balance);
            Console.WriteLine(loanInd.CalculateMonthlyInterest(4));

            Console.WriteLine("\nMortgage account Individual:");
            Account mortgageInd = new MortgageAccount(indX, 0.2m);
            Console.WriteLine(mortgageInd.Balance);
            mortgageInd.DepositMoney(1000);
            Console.WriteLine(mortgageInd.Balance);
            Console.WriteLine(mortgageInd.CalculateMonthlyInterest(7));

            Console.WriteLine("\nMortgage account Company:");
            Account mortgageCompany = new MortgageAccount(compY, 0.5m);
            Console.WriteLine(mortgageCompany.Balance);
            mortgageCompany.DepositMoney(1000);
            Console.WriteLine(mortgageCompany.Balance);
            Console.WriteLine(mortgageCompany.CalculateMonthlyInterest(13));

            Account[] accounts = new Account[]
            {
                new DepositAccount(new Individual("Pencho Ivanov", "2132131422" ), 1.2m),
                new DepositAccount(new Company("Sinya sliva EOOD", "1333435367"), 0.21m),
                new LoanAccount(new Individual("Kolyo Pentchev", "43245564657"), 3),
                new LoanAccount(new Company("Zelena yabulka EOOD", "133248965"), 0.35m),
                new MortgageAccount(new Individual("Kirilka Kochanova", "35467893213"), 0.08m),
                new MortgageAccount(new Company("Cherven domat EOOD", "133049321"), 0.34m)
            };

            foreach (Account account in accounts)
            {
                Console.WriteLine();
                Console.WriteLine("{0}: {1}, {2}: interest rate {3}", account.AccountHolder.GetType().Name, account.AccountHolder.Name, account.GetType().Name, account.MonthlyInterestRate);
                Console.WriteLine("Initial balance: {0}", account.Balance);
                account.DepositMoney(10000);
                Console.WriteLine("After deposit balance: {0}", account.Balance);
                Console.WriteLine("13 months period interest: {0}", account.CalculateMonthlyInterest(13));                
            }
        }
    }
}
