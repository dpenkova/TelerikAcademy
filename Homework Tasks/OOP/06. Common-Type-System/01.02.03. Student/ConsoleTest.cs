using System;

namespace Student
{
    class ConsoleTest
    {
        static void Main()
        {
            Student st1 = new Student("Kiro", "Pavlov", "Ivanov", "7812042345", "0887234345", "kiro.ivanov@abv.bg", "2E", University.TU, Faculty.Transport, Specialty.AirTransport);
            Student st2 = new Student("Kiro", "Pavlov", "Ivanov", "7812042345", "0887234345", "kiro.ivanov@abv.bg", "2E", University.TU, Faculty.Transport, Specialty.AirTransport);
            Student st3 = st1;

            Console.WriteLine(st1);
            Console.WriteLine(st2);
            Console.WriteLine(st3);
            Console.WriteLine();

            Console.WriteLine("St1 equals st2: {0}", st1.Equals(st2));
            st3.University = University.SU;
            st1.FirstName = "Haralambi";
            Console.WriteLine("St1 equals st2: {0} --> after change of st3 linked to st1", st1.Equals(st2));
            Console.WriteLine();
            
            Console.WriteLine("Hash codes:");
            Console.WriteLine("st1 == st2 : {0}", st1 == st2);
            Console.WriteLine("Hash code st1: {0}", st1.GetHashCode());
            Console.WriteLine("Hash code st2: {0}", st2.GetHashCode());
            Console.WriteLine("Hash code st3: {0}\n", st3.GetHashCode());

            Console.WriteLine("Clones:");
            Student st4 = st2.Clone();
            Console.WriteLine("st4 clone of st2 is equal to st2: {0}", Equals(st2, st4));
            st4.University = University.UNWE;
            st4.FirstName = "Katq";
            Console.WriteLine("st4 clone of st2 is equal to st2: {0} --> after change in st4", Equals(st2, st4));

            Student st5 = new Student("Kiro", "Pavlov", "Kirilov", "7612345678", "0887234345", "kiro.ivanov@abv.bg", "2E", University.TU, Faculty.Transport, Specialty.AirTransport);
            Student st6 = new Student("Kirolan", "Pavlov", "Atanasov", "123456789", "0887234345", "kiro.ivanov@abv.bg", "2E", University.TU, Faculty.Transport, Specialty.AirTransport);
            Student st7 = new Student("Kiro", "Pavlov", "Ivanov", "1239876544", "0887234345", "kiro.ivanov@abv.bg", "2E", University.TU, Faculty.Transport, Specialty.AirTransport);
            Student st8 = new Student("Albena", "Pavlov", "Ivanova", "9876543223", "0887234345", "kiro.ivanov@abv.bg", "2E", University.TU, Faculty.Transport, Specialty.AirTransport);


            Student[] students = new[] { st1, st2, st3, st4, st5, st6, st7, st8 };
            Array.Sort(students);

            Console.WriteLine("\nSort students: ");

            foreach (var st in students)
            {
                Console.WriteLine("{0} {1} {2} - {3}", st.FirstName, st.MiddleName, st.LastName, st.SSN);
            }
            
        }
    }
}
