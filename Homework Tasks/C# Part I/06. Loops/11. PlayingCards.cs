/* 11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
* The cards should be printed with their English names. Use nested for loops and switch-case.*/

using System;

class PlayingCards
{
    static void Main()
    {
        string[] symbols = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Knave", "Qeen", "King", "Ace" };
        string[] colors = { "Clubs", "Hearts", "Diamonds", "Spades" };

        for (int i = 0; i < colors.Length; i++)
        {
            for (int j = 0; j < symbols.Length; j++)
            {
                Console.Write("{0} of ", symbols[j]);
                Console.WriteLine("{0}", colors[i]);
            }
        }

        // using foreach

        //foreach (var color in colors)
        //{
        //    foreach (var symbol in symbols)
        //    {
        //        Console.Write("{0} of ", symbol);
        //        Console.WriteLine("{0}", color);
        //    }
        //    Console.WriteLine("------");
        //}
    }
}
