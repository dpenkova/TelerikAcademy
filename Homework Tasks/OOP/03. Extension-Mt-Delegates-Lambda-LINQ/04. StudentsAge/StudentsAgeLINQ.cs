using System;
using System.Linq;

// Task 04 - Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

    class StudentsAgeLINQ
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
            };

            var qryResult =
                from student in students
                where student.age >= 18 && student.age <= 24
                // orderby student.age + student.firstName + student.lastName
                select new { student.firstName, student.lastName};

            foreach (var item in qryResult)
            {
                Console.WriteLine(item);
            }


            // using Lambda

            var lambdaQry = students.Where(student => student.age >= 18 && student.age <= 24).OrderBy(st => st.age).ThenBy(st => st.firstName).ThenBy(s => s.lastName);

            Console.WriteLine();

            foreach (var item in lambdaQry)
            {
                Console.WriteLine("{0} {1} {2}", item.age, item.firstName, item.lastName);
            }
        }
    }