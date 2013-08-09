using System;

class ReadLinePrintAgePlus_10
{
    static void Main()
    {
        bool result = false;
        int age = 0;
        while (result == false) 
        {   
            Console.Write("Write your age: ");
            string ageline = Console.ReadLine();
            result = Int32.TryParse(ageline, out age);
            if (result == false)
            {
                Console.WriteLine("You must enter a hole number." + "\n");
            }   
        }
        Console.WriteLine("In ten years you'll be {0} years old", age + 10);
    }
}

