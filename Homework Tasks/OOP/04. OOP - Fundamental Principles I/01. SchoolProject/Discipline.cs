using System;
using System.Text;

namespace SchoolProject
{
    public class Discipline
    {
       public string Name { get; private set; }
       public uint NumberOfLectures { get; private set; }
       public uint NumberOfExercises { get; private set; }
       public string Comment { get; set; }
       
        public Discipline(string name, uint lectures, uint exercises, string comment)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Discipline name cannot be null or empty.");
            }

            if (lectures < 0 )
            {
                throw new ArgumentException("Number of lectures cannot be negative number.");
            }

            if (exercises < 0)
            {
                throw new ArgumentException("Number of exercises cannot be negative number.");
            }

            this.Name = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises;
            this.Comment = comment;
        }

        public Discipline(string name, uint lectures, uint exercises)
            : this(name, lectures, exercises, null)
        { }

        public override string ToString()
        {
            StringBuilder disciplineInfo = new StringBuilder();

            disciplineInfo.AppendFormat("{0}: Nb of Lectures: {1}, Nb of exercises: {2}{3}", this.Name, this.NumberOfLectures, this.NumberOfExercises, this.Comment!= null ? ", Comment: "+ this.Comment : null);
            return disciplineInfo.ToString();
        }
    }
}
