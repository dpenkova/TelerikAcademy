/* A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
 * bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed 
 * to keep the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccountRecord
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Ivanov";
        decimal balance = 99999999.99M;
        string bankName = "Банка ДСК - ЕООД";
        string iban = "BG70STSA23034078498453";
        string bicCode = "STSABGSF";
        ulong? cardNumber01 = 0483034303094239;
        ulong? cardNumber02 = 2309845043980430;
        ulong? cardNumber03 = null;

        Console.WriteLine("Name: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Balance: {0} BGN", balance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}, BIC Code: {1}", iban, bicCode);
        Console.WriteLine("Card number 01: {0}", cardNumber01);
        Console.WriteLine("Card number 02: {0}", cardNumber02);
        Console.WriteLine("Card number 03: {0}\n", cardNumber03);
    }
}
