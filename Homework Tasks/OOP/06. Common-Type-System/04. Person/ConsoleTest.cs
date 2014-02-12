namespace Person
{
    class ConsoleTest
    {
        static void Main()
        {
            Person p1 = new Person("Katq", 3);
            Person p2 = new Person("Kiro", 6);
            Person p3 = new Person("Anton");

            Person[] persons = new[] { p1, p2, p3};

            foreach (var person in persons)
            {
                System.Console.WriteLine(person);
            }

        }
    }
}
