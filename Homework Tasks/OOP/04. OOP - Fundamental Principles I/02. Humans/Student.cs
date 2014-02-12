using System;
using System.Text;

namespace Humans
{
    public class Student: Human
    {
        public int Grade { get; private set; }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            if (grade < 2 && grade > 6)
            {
                throw new ArgumentOutOfRangeException("Invalid grade. Enter a value from 2 to 6.");
            }
            
            this.Grade = grade;
        }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();

            studentInfo.AppendFormat("{0} {1}", base.ToString(), this.Grade);

            return studentInfo.ToString();
        }
    }
}
