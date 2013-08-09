using System;

class PrintFirst_10_MembersOfTheSequence
{
    static void Main()
    {
        int changeSign = 1;
        for (int i = 2; i < 2 + 10; i++)
        {
            Console.Write("{0} ", i * changeSign);
            changeSign = changeSign * -1;
        }
        Console.WriteLine();
    }
}

