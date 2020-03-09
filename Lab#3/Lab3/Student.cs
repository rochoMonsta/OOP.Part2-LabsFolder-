using System;

namespace Lab3
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public Student() { }
        public Student(string Name, string Surname, int Age, string Group)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException(nameof(Name), "Wrong type of Name.");
            else
                this.Name = Name;

            if (string.IsNullOrWhiteSpace(Surname))
                throw new ArgumentNullException(nameof(Surname), "Wrong type of Surname.");
            else
                this.Surname = Surname;

            if (Age <= 0)
                throw new ArgumentException(nameof(Age), "Wrong age.");
            else
                this.Age = Age;

            if (string.IsNullOrWhiteSpace(Group))
                throw new ArgumentNullException(nameof(Group), "Wrong type of Group");
            else
                this.Group = Group;
        }
        public Student(string[] studentInfo)
        {
            this.Name = studentInfo[0];
            this.Surname = studentInfo[1];
            this.Age = int.Parse(studentInfo[2]);
            this.Group = studentInfo[3];
        }
        public override string ToString()
        {
            return $"{Name} {Surname} - {Age} - {Group}";
        }
    }
}
