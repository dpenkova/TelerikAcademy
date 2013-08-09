/* A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints them on the console. */

using System;

    class CompanyAndManagerData
    {
        static void Main()
        {
            Console.Write("Enter Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter Company phone: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Enter Company fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Enter Company web site: ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Enter Company Manager's first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Enter Company Manager's last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter Manager's age: ");
            uint managerAge;
            while (!uint.TryParse(Console.ReadLine(), out managerAge) || managerAge > 100 || managerAge < 18)
            {
                Console.Write("Invalid entry! Please enter correct age (100 > age > 18): ");
            }
            Console.Write("Enter Company Manager's phone number: ");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine("\n--- Company data ---\n");
            Console.WriteLine("{0,-23} {1}", "Company name:", companyName);
            Console.WriteLine("{0,-23} {1}", "Company address:", companyAddress);
            Console.WriteLine("{0,-23} {1}", "Company phone number:", companyPhone);
            Console.WriteLine("{0,-23} {1}", "Company fax number:", companyFax);
            Console.WriteLine("{0,-23} {1}", "Company web site:", companyWebSite);

            Console.WriteLine("\n--- Manager data ---\n");
            Console.WriteLine("{0,-23} {1}", "Manager name:", (managerFirstName + " " + managerLastName));
            Console.WriteLine("{0,-23} {1}", "Manager age:", managerAge);
            Console.WriteLine("{0,-23} {1}\n", "Manager phone number:", managerPhoneNumber);
        }
    }

