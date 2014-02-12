using System;
using System.Text;

namespace Humans
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("Name cannot be null or white space.");
            }

            if (string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Name cannot be null or white space.");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder humanInfo = new StringBuilder();
            humanInfo.AppendFormat("{0} {1}",  this.FirstName, this.LastName);
            return humanInfo.ToString();
        }
    }
}
