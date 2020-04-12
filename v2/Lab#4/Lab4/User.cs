using System;

namespace Lab4
{
    public class User : IUserInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public User() { }
        public User(string Name, string Surname)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException(nameof(Name), "Wrong type of Name.");
            else
                this.Name = Name;

            if (string.IsNullOrWhiteSpace(Surname))
                throw new ArgumentNullException(nameof(Surname), "Wrong type of Surname.");
            else
                this.Surname = Surname;
        }
        public override string ToString()
        {
            return $"\n{Name} {Surname}";
        }
    }
}