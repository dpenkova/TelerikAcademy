using System;
using System.Collections.Generic;

namespace SchoolProject
{
    class ConsoleTest
    {
        static void Main()
        {
            List<Student> class7A = new List<Student>();
            class7A.Add(new Student(1, "Nikola", "Nikolov", "some comment"));
            class7A.Add(new Student(2, "Angel", "Petrov"));
            class7A.Add(new Student(3, "Emil", "Kolev"));
            class7A.Add(new Student(4, "Kaloyan", "Varbanov"));

            List<Student> class7B = new List<Student>();
            class7B.Add(new Student(1, "Alex", "Ivanov"));
            class7B.Add(new Student(2, "Andrey", "Mihajlov", "dummy comment"));
            class7B.Add(new Student(3, "Ani", "Boeva"));
            class7B.Add(new Student(4, "Marina", "Sofyiska"));
            class7B.Add(new Student(5, "Martin", "Karaivanov"));

            List<Discipline> petrovasList = new List<Discipline>();
            petrovasList.Add(new Discipline("C# part One", 9, 9));
            petrovasList.Add(new Discipline("C# part Two", 9, 9));
            petrovasList.Add(new Discipline("C# part Three", 9, 9));
            petrovasList.Add(new Discipline("C# part Four", 9, 9));

            List<Discipline> nikolovsList = new List<Discipline>();
            nikolovsList.Add(new Discipline("C# part One", 8, 7));
            nikolovsList.Add(new Discipline("C# part Two", 7, 7));
            nikolovsList.Add(new Discipline("OOP part One", 10, 9));
            nikolovsList.Add(new Discipline("OOP part Two", 9, 11));
            nikolovsList.Add(new Discipline("KPK course", 8, 9));

            List<Discipline> kostovasList = new List<Discipline>();
            kostovasList.Add(new Discipline("PHP", 8, 7));
            kostovasList.Add(new Discipline("HTML 5", 7, 7));
            kostovasList.Add(new Discipline("CSS", 10, 9));

            List<Discipline> alexandrovsList = new List<Discipline>();
            alexandrovsList.Add(new Discipline("OOP part Two", 9, 11, "comment"));
            alexandrovsList.Add(new Discipline("KPK course", 8, 9));

            Teacher petrova = new Teacher(petrovasList, "Ivanka", "Petrova");
            Teacher nikolov = new Teacher(nikolovsList, "Alex", "Nikolov", "comment 2");
            Teacher kostova = new Teacher(kostovasList, "Donka", "Kostova");
            Teacher alexandrov = new Teacher(alexandrovsList, "Igor", "Alexandrov");

            List<Teacher> teachersSetOne = new List<Teacher>() { petrova, alexandrov};
            List<Teacher> teachersSetTwo = new List<Teacher>() { nikolov, kostova };

            List<ClassOfStudents> classes = new List<ClassOfStudents>();
            classes.Add(new ClassOfStudents("7A", class7A, teachersSetOne, "class A comment"));
            classes.Add(new ClassOfStudents("7B", class7B, teachersSetTwo));

            School telerik = new School("Telerik Academy", classes);

            Console.WriteLine(telerik);
        }
    }
}
