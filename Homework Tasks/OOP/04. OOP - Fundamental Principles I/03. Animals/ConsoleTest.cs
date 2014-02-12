using System;
using System.Collections.Generic;
using System.Linq;

// Task 03 - Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
// Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
// Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female 
// and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals 
// and calculate the average age of each kind of animal using a static method (you may use LINQ).


namespace Animals
{
    class ConsoleTest
    {
        public static decimal AverageAge(Animal[] animals)
        {
            decimal sum = 0;

            foreach (Animal animal in animals)
            {
                sum += animal.Age;
            }

            return sum / animals.Length;
        }

        //// vic alexiev 
        //private static IEnumerable<Tuple<string, double>> GetAverageAges(Animal[] animals)
        //{
        //    var averageAges =
        //        from animal in animals
        //        group animal by animal.GetType() into animalType
        //        select new Tuple<string, double>(animalType.Key.Name, animalType.Average(a => a.Age));

        //    return averageAges;
        //}

        // Calculate Average age using linq 
        private static double AverageAgeLinq(Animal[] animals)
        {
            double averageAge = animals.Average(x => x.Age);
            return averageAge;
        }
       
        static void Main()
        {
            Animal[] dogs = 
            {
                new Dog("Charlie", 2, Gender.Male), 
                new Dog("Djaro", 6, Gender.Male),
                new Dog("Dino", 17, Gender.Male),
                new Dog("Chara", 5, Gender.Female),
                new Dog("Gabi", 8, Gender.Female),
                new Dog("Karla", 15, Gender.Female),
            };

            Cat[] cats = 
            {
                new Kitten("Choki", 1),
                new Tomcat("Tom", 6),
                new Tomcat("Rijko", 3),
                new Tomcat("Roshko", 14),
                new Kitten("Bijou", 2),
            };

            Frog[] frogs = 
            {
                new Frog("Sam", 1, Gender.Male),
                new Frog("Jessie", 3, Gender.Female),
                new Frog("John", 5, Gender.Male),
                new Frog("Jaba", 11, Gender.Male),
                new Frog("Olivia", 4, Gender.Female),
            };

            Console.WriteLine("Average dogs' age: {0:F2}", AverageAge(dogs));
            Console.WriteLine("Average cats' age: {0:F2}", AverageAge(cats));
            Console.WriteLine("Average frogs' age: {0:F2}", AverageAge(frogs));
            Console.WriteLine();

            Console.WriteLine("Using linq");
            Console.WriteLine("Average dogs' age: {0:F2}", AverageAgeLinq(dogs));
            Console.WriteLine("Average cats' age: {0:F2}", AverageAgeLinq(cats));
            Console.WriteLine("Average frogs' age: {0:F2}", AverageAgeLinq(frogs));


            // make them all produce sound

            var animalsMerged = dogs.Concat<Animal>(cats).Concat<Animal>(frogs).OrderBy(x => x.Name);

            Console.WriteLine();
            foreach (Animal animal in animalsMerged)
            {
                Console.WriteLine("{0} says: {1}", animal.Name, animal.ProduceSound());
            }

            //// vic alexiev

            //Animal[] animals = 
            //{
            //    new Dog("Charlie", 2, Gender.Male), 
            //    new Dog("Djaro", 6, Gender.Male),
            //    new Dog("Dino", 17, Gender.Male),
            //    new Dog("Chara", 5, Gender.Female),
            //    new Dog("Gabi", 8, Gender.Female),
            //    new Dog("Karla", 15, Gender.Female),
            //    new Kitten("Choki", 1),
            //    new Tomcat("Tom", 6),
            //    new Tomcat("Rijko", 3),
            //    new Tomcat("Roshko", 14),
            //    new Kitten("Bijou", 2),
            //    new Frog("Sam", 1, Gender.Male),
            //    new Frog("Jessie", 3, Gender.Female),
            //    new Frog("John", 5, Gender.Male),
            //    new Frog("Jaba", 11, Gender.Male),
            //    new Frog("Olivia", 4, Gender.Female),
            //};

            //var averageAges = GetAverageAges(animals);
            //foreach (var tuple in averageAges)
            //{
            //    Console.WriteLine("Animal: {0}, Average Age: {1:F2}", tuple.Item1, tuple.Item2);
            //}
        }
    }
}
