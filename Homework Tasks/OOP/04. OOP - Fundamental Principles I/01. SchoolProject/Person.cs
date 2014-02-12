using System;

namespace SchoolProject
{
    public abstract class Person
    {
        public string FirstName { get; private set; }
        public string FamilyName { get; private set; }
        public string Comment { get; set; }


        protected Person(string firstName, string familyName, string comment )
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("First name can't be null or empty.");
            }
            if (string.IsNullOrWhiteSpace(familyName) || string.IsNullOrEmpty(familyName))
            {
                throw new ArgumentException("Family name can't be null or empty.");
            }
            this.FirstName = firstName;
            this.FamilyName = familyName;
            this.Comment = comment;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.FirstName, this.FamilyName, this.Comment!= null ? ":: Comment: " + this.Comment : null);
        }
    }
}
