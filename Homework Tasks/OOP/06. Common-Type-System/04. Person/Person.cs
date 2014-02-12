namespace Person
{
    /* Task 04: 
     * Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
     * Override ToString() to display the information of a person and if age is not specified – to say so. Write a 
     * program to test this functionality.
     */

    public class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Person(string name, int? age = null)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new System.ArgumentException("Name cannot be null or white space.");    
            }
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\n", this.Name, this.Age == null ? "Not specified" : this.Age.ToString() );
        }
    }
}
