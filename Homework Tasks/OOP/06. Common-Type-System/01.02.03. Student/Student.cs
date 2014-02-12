using System;

namespace Student
{
    /* Task 01:
     * Define a class Student, which contains data about a student – first, middle and last name, SSN, 
     * permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration 
     * for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: 
     * Equals(), ToString(), GetHashCode() and operators == and !=.
     */

    class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        public Student(string firstName, string middleName, string lastName, string ssn, string mobile, string email, string course,
            University university, Faculty faculty, Specialty specialty, string address = null)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Mobile = mobile;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public override bool Equals(object obj)
        {
            Student compareStudent = obj as Student;

            if ((object)compareStudent == null)
            {
                return false;
            }

            return Equals(this.FirstName, compareStudent.FirstName)
                && Equals(this.MiddleName, compareStudent.MiddleName)
                && Equals(this.LastName, compareStudent.LastName)
                && Equals(this.SSN, compareStudent.SSN)
                && Equals(this.Address, compareStudent.Address)
                && Equals(this.Mobile, compareStudent.Mobile)
                && Equals(this.Email, compareStudent.Email)
                && Equals(this.Course, compareStudent.Course)
                && Equals(this.University, compareStudent.University)
                && Equals(this.Faculty, compareStudent.Faculty)
                && Equals(this.Specialty, compareStudent.Specialty);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode()
                 ^ this.MiddleName.GetHashCode()
                 ^ this.LastName.GetHashCode()
                 ^ this.SSN.GetHashCode()
                 ^ (Address != null ? this.Address.GetHashCode() : 0)
                 ^ this.Mobile.GetHashCode()
                 ^ this.Email.GetHashCode()
                 ^ this.Course.GetHashCode()
                 ^ this.University.GetHashCode()
                 ^ this.Faculty.GetHashCode()
                 ^ this.Specialty.GetHashCode();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override string ToString()
        {
            return string.Format("Student Name: {0}\nSSN: {1} \nAddress: {2}\nMobile: {3}\nEmail: {4}\nCourse: {5}\nUniversity: {6}\nFaculty: {7}\nSpecialty: {8}\n--------\n", 
                this.FirstName + " " + this.MiddleName + " " + this.LastName, this.SSN, (Address != null ? this.Address : "Not supplied"), 
                this.Mobile, this.Email, this.Course, this.University, this.Faculty, this.Specialty);
        }


        /* Task 02: 
         * Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields 
         * into a new object of type Student.
         */

        public Student Clone()
        {
            Student cloned = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Mobile, this.Email, this.Course, this.University, this.Faculty, this.Specialty, this.Address);
            return cloned;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        /* Task 03: 
         * Implement the IComparable<Student> interface to compare students by names (as first criteria, 
         * in lexicographic order) and by social security number (as second criteria, in increasing order).
         */

        public int CompareTo(Student otherStudent)
        {
            string thisFullName = string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            string otherFullName = string.Format("{0} {1} {2}", otherStudent.FirstName, otherStudent.MiddleName, otherStudent.LastName);

            if (thisFullName != otherFullName)
            {
                return string.Compare(thisFullName, otherFullName);
            }

            if (this.SSN != otherStudent.SSN)
            {
                return string.Compare(this.SSN, otherStudent.SSN);
            }

            return 0;
        }
    }
}
