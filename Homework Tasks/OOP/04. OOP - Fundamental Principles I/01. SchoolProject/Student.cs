using System;

namespace SchoolProject
{
    public class Student : Person
    {
        public uint UniqueID { get; private set; }

        public Student(uint uniqueID, string name, string lastName, string comment)
            : base(name, lastName, comment)
        {
            this.UniqueID = uniqueID;
        }

        public Student(uint uniqueID, string name, string lastName)
            : this(uniqueID, name, lastName, null)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.UniqueID, base.ToString());
        }
    }
}
