using System;

namespace GenericList
{
    class ConsoleTests
    {
        static void Main()
        {
            // create new object
            GenericList<int> test = new GenericList<int>(1);
            // addind elements
            test.AddItem(2);
            test.AddItem(34);
            test.AddItem(3);
            test.AddItem(22);

            // indexing
            Console.WriteLine(test[1]);
            test[1] = 23;
            Console.WriteLine(test[1]);

            // remove by index
            test.RemoveItemByIndex(1);
            Console.WriteLine(test);

            // insert at position
            test.AddItem(44);
            Console.WriteLine(test);
            test.InsertItemAtPosition(3, -33);
            Console.WriteLine(test);

            

            // find index by value
            Console.WriteLine(test.FindIndex(44));
            Console.WriteLine(test.FindIndex(46));

            // override ToString()
            Console.WriteLine(test);

            // Min value method
            Console.WriteLine(test.MinItem());

            // Max value method
            Console.WriteLine(test.MaxItem());

            // clear list
            test.ClearList();
            Console.WriteLine(test);
        }
    }
}
