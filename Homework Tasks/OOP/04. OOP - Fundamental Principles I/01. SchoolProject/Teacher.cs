using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    public class Teacher : Person
    {

        public List<Discipline> SetOfDisciplines { get; private set; }
        

        public Teacher(List<Discipline> courseSet, string name, string lastName, string comment)
            : base (name, lastName, comment)
        {
            this.SetOfDisciplines = new List<Discipline>(courseSet);
        }

        public Teacher(List<Discipline> courseSet, string name, string lastName)
            : this(courseSet, name, lastName, null)
        {
        }

        public override string ToString()
        {
            StringBuilder teacherData = new StringBuilder();

            teacherData.AppendFormat("{0}\n{1}", base.ToString(), SetOfDisciplines.Count == 0 ? "No Disciplines assigned\n" : "Disciplines:\n");
            foreach (var course in this.SetOfDisciplines)
            {
                teacherData.AppendFormat("{0}\n", course);
            }

            teacherData.AppendFormat("----------------------\n");

            return teacherData.ToString();
        }
    }
}
