using System;

namespace VersionAttribute
{
    [Version ("2.11")]

    class TestClass
    {
        static void Main()
        {
            Type type = typeof(TestClass);
            object[] attr = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}
