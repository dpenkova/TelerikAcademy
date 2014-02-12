using System;
using System.Collections.Generic;
using System.Linq;

// Task 02 - Define abstract class Human with first name and last name. Define new class Student which is derived from Human 
// and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
// and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties 
// for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension 
// method). Initialize a list of 10 workers and sort them by money per hour in descending order. Merge the lists and sort them by 
// first name and last name.


namespace Humans
{
    class ConsoleTest
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student("Joro", "Petrov", 3));
            studentList.Add(new Student("Nikola", "Nikolov", 6));
            studentList.Add(new Student("Angel", "Petrov", 5));
            studentList.Add(new Student("Emil", "Kolev", 2));
            studentList.Add(new Student("Kaloyan", "Varbanov", 4));
            studentList.Add(new Student("Marina", "Sofyiska", 3));
            studentList.Add(new Student("Martin", "Karaivanov", 6));
            studentList.Add(new Student("Alex", "Ivanov", 5));
            studentList.Add(new Student("Andrey", "Mihajlov", 4));
            studentList.Add(new Student("Ani", "Boeva", 2));

            // Sort students by grade Using lambda
            var studentsByGrade = studentList.OrderBy(x => x.Grade).ThenBy(n => n.FirstName).ThenBy(l => l.LastName);
            
            foreach (var student  in studentsByGrade)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // Sort students by grade using LINQ
            var studentsByGradeLinq =
                from student in studentList
                orderby student.Grade, student.FirstName, student.LastName
                select student;

            foreach (var student in studentsByGradeLinq)
            {
                Console.WriteLine("{0} {1} {2}", student.Grade, student.FirstName, student.LastName);
            }
            Console.WriteLine();

            List<Worker> workersList = new List<Worker>();

            workersList.Add(new Worker("Ivan", "Ivanov", 300, 6));
            workersList.Add(new Worker("Maya", "Popova", 300, 8));
            workersList.Add(new Worker("Kirilka", "Ivanova", 250, 8));
            workersList.Add(new Worker("Ilona", "Kozlovska", 50, 4));
            workersList.Add(new Worker("Eva", "Kamenova", 500, 8));
            workersList.Add(new Worker("Donika", "Petkova", 650, 8));
            workersList.Add(new Worker("Daniela", "Stefanova", 1000, 4));
            workersList.Add(new Worker("Kristian", "Andreev", 300, 8));
            workersList.Add(new Worker("Mike", "Smith", 2000, 7));
            workersList.Add(new Worker("Jaime", "Murray", 5000, 5));

            // Sort workers by MoneyPerHour Using lambda
            var workersByHourSalary = workersList.OrderByDescending(x => x.MoneyPerHour()).ThenBy(n => n.FirstName).ThenBy(l => l.LastName);

            foreach (var worker in workersByHourSalary)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            // Sort workers by MoneyPerHour using LINQ
            var workersByHourSalaryLinq =
                from worker in workersList
                orderby worker.MoneyPerHour() descending, worker.FirstName, worker.LastName
                select worker;

            foreach (var worker in workersByHourSalaryLinq)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

           

            var mergedList = studentList.Concat<Human>(workersList).OrderBy(x => x.FirstName).ThenBy(y => y.LastName);

            // prints name and grade for student or hourSalary for worker
            foreach (var human in mergedList)
            {
                Console.WriteLine(human);
            }

            // prints only firstName and lastName
            //foreach (var human in mergedList)
            //{
            //    Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            //}



            // or another way - using anonymous type and Union
            var mergedL =
                (from student in studentList
                 select new 
                 {
                     FirstName = student.FirstName,
                     LastName = student.LastName,
                 }
                  ).Union(from worker in workersList
                          select new 
                          {
                              FirstName = worker.FirstName,
                              LastName = worker.LastName,
                          }
                           ).OrderBy(x => x.FirstName).ThenBy(y => y.LastName);

            Console.WriteLine();
            foreach (var human in mergedL)
            {
                Console.WriteLine(human);
            }



            // This would work only if the class Human is not abstract, and have an empty constructor
            //var mergedL =
            //    (from student in studentList
            //     select new Human
            //     {
            //         FirstName = student.FirstName,
            //         LastName = student.LastName,
            //     }
            //      ).Union(from worker in workersList
            //              select new Human
            //              {
            //                  FirstName = worker.FirstName,
            //                  LastName = worker.LastName,
            //              }
            //               ).OrderBy(x => x.FirstName).ThenBy(y => y.LastName);
            //
            //Console.WriteLine();
            //foreach (var human in mergedL)
            //{
            //    Console.WriteLine(human);
            //}
        }                               
    }
}
