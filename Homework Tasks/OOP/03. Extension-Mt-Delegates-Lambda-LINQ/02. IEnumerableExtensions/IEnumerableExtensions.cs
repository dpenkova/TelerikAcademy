using System;
using System.Collections.Generic;
using System.Linq;

// Task 02 - Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace IEnumerableExtensions
{
    public static class IEnumerableExtensions
    { 
        public static T Sum<T>(this IEnumerable<T> input) where T : IComparable, IComparable<T>, IFormattable, IEquatable<T>
        {
            CheckForEmptyCollection<T>(input);
            CheckNullInput<T>(input);
            dynamic result = 0;

            foreach (var item in input)
            {
                result += item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> input) where T : IComparable, IComparable<T>, IFormattable, IEquatable<T>
        {
            CheckForEmptyCollection<T>(input);
            CheckNullInput<T>(input);
            dynamic result = 1;

            foreach (var item in input)
            {
                result *= item;
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable, IComparable<T>
        {
            CheckForEmptyCollection<T>(input);
            CheckNullInput<T>(input);

            dynamic result = (dynamic)input.First();

            foreach (var item in input)
            {
                if (result > item)
                {
                    result = (dynamic)item;
                }
            }
            return result;
        }

        public static T Max<T>(this IEnumerable<T> input) where T : IComparable, IComparable<T>
        {
            CheckForEmptyCollection<T>(input);
            CheckNullInput<T>(input);

            dynamic result = (dynamic)input.First();

            foreach (var item in input)
            {
                if (result < item)
                {
                    result = (dynamic)item;
                }
            }
            return result;
        }

        public static dynamic Average<T>(this IEnumerable<T> input) where T : IComparable, IComparable<T>
        {
            CheckForEmptyCollection<T>(input);
            CheckNullInput<T>(input);

            dynamic sum = 0;
            double counter = 0;

            foreach (var item in input)
            {
                sum += item;
                counter++;
            }

            dynamic result = sum / counter;
            return  result;
        }

        private static void CheckNullInput<T>(IEnumerable<T> input) 
        {
            if (input == null)
            {
                throw new ArgumentNullException("Invalid input");
            }
        }

        private static void CheckForEmptyCollection<T>(IEnumerable<T> input)
        {
            if (input.FirstOrDefault() == null)
            {
                throw new ArgumentNullException("No arguments");
            }
        }

       
    }
}
