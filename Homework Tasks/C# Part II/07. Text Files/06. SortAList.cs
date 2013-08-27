/* Write a program that reads a text file containing a list of strings, sorts them 
 * and saves them to another text file. Example:
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortAList
{
    static void Main()
    {
        Console.WriteLine("Enter a file name and path:");
        string filePath = Console.ReadLine();

        List<string> list = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {  
            string line = reader.ReadLine();

            while (line != null)
            {
                list.Add(line);
                line = reader.ReadLine();
            }
        }

        list.Sort();

        Console.WriteLine("Enter destination file name and path:");

        using (StreamWriter writer = new StreamWriter(Console.ReadLine()))
        {
            foreach (var item in list)
            {
                writer.WriteLine(item);
            }
        }
    }
}
