using System;
using System.Linq;

// Task 03 - Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. 
// Use LINQ query operators.


class StudentsNamesLINQ
{
    static void Main()
    {
        var students = new[]
        {
            new { firstName = "Pesho", lastName = "Andreev" },
            new { firstName = "Andrey", lastName = "Peshev" },
            new { firstName = "Kalin", lastName = "Ivanov" },
            new { firstName = "Misho", lastName = "Nikolov" },
            new { firstName = "Kaloyan", lastName = "Andreev" },
            new { firstName = "Kaloyan", lastName = "Petkov" },
        };

        var qryResult =
            from student in students
            where student.firstName.CompareTo(student.lastName) < 0
            //orderby student.firstName, student.lastName
            select student;

        foreach (var item in qryResult)
        {
            Console.WriteLine("{0} {1}", item.firstName, item.lastName);
        }

        // using Lambda

        var lambdaQry = students.Where( st => st.firstName.CompareTo(st.lastName) < 0); // .OrderBy( student => student.firstName).ThenBy(student => student.lastName);

        Console.WriteLine();

        foreach (var item in lambdaQry)
        {
            Console.WriteLine("{0} {1}", item.firstName, item.lastName);
        }


    }
}