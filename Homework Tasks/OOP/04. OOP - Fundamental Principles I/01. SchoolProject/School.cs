using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    public class School
    {
        public string Name {get; private set;}
        public List<ClassOfStudents> SetOfClasses { get; private set; }

        public School(string name, List<ClassOfStudents> classes)
        {
            this.Name = name;
            this.SetOfClasses = new List<ClassOfStudents>(classes);
        }

        public override string ToString()
        {

            StringBuilder schoolInfo = new StringBuilder();

            schoolInfo.AppendFormat("School name: {0}\n", this.Name);

            foreach (var stClass in SetOfClasses)
            {
                schoolInfo.AppendFormat("{0}\n", stClass);
            }

            return schoolInfo.ToString();
        }
       
    }
}
