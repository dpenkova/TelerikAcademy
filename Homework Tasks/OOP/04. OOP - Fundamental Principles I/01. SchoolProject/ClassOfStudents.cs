using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    public class ClassOfStudents
    {
        public string UniqueTextIdentifier { get; private set; }
        public List<Student> SetOfStudents { get; private set; }
        public List<Teacher> SetOfTeachers { get; private set; }
        public string Comment { get; set; }

        public ClassOfStudents(string id, List<Student> students, List<Teacher> teachers, string comment)
        {
            this.UniqueTextIdentifier = id;
            this.SetOfStudents = new List<Student>(students);
            this.SetOfTeachers = new List<Teacher>(teachers);
            this.Comment = comment;
        }

        public ClassOfStudents(string id, List<Student> students, List<Teacher> teachers)
            : this(id, students, teachers, null)
        {
        }

        public override string ToString()
        {
            StringBuilder classInfo = new StringBuilder();

            classInfo.AppendFormat("Class: {0}{1}\n{2}", this.UniqueTextIdentifier, string.IsNullOrWhiteSpace(this.Comment) ? null : " Comment: " + this.Comment, this.SetOfStudents.Count != 0 ? "Students:\n" : "No students in this class.");
            foreach (var student in SetOfStudents)
            {
                classInfo.AppendFormat("{0}\n", student);
            }

            classInfo.AppendFormat("{0}", this.SetOfTeachers.Count != 0 ? "\nTeachers:\n" : "\nNo teachers assigned to this class.");
            foreach (var teacher in SetOfTeachers)
            {
                classInfo.AppendFormat("{0}\n", teacher);
            }

            return classInfo.ToString();
        }
    }
}
