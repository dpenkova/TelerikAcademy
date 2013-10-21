using System;
using System.Linq;

// Task 05 - Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
// by first name and last name in descending order. Rewrite the same with LINQ.

namespace SortStudentsByName
{
    class SortStudentsByName
    {
        static void Main()
        {
            var students = new[]
            {
                new { firstName = "Pesho", lastName = "Andreev", age = 23},
                new { firstName = "Andrey", lastName = "Peshev" , age = 28},
                new { firstName = "Kalin", lastName = "Ivanov", age = 18},
                new { firstName = "Misho", lastName = "Nikolov", age = 15},
                new { firstName = "Kaloyan", lastName = "Andreev", age = 18},
                new { firstName = "Jaime", lastName = "Murray", age = 36},
            };

            // sort using Lambda expressions

            var lambdaSort = students.OrderByDescending(x => x.firstName).ThenByDescending(x => x.lastName);

            foreach (var student in lambdaSort)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }
            Console.WriteLine();

            // sort using LINQ

            var linqSort =
                from student in students
                orderby student.firstName descending, student.lastName descending
                select student;

            foreach (var student in linqSort)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }
            Console.WriteLine();
        }
    }
}
