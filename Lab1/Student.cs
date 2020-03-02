using System;

namespace Lab1
{
    class Student
    {
        public static Random random = new Random(DateTime.Now.Millisecond);
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Hostel { get; set; }
        public Time TimeOfExitFromHostel = new Time();
        public Student() { }
        public override string ToString()
        {
            return $"{Name} {Surname} - {Age} - {Group} - {Hostel} - {TimeOfExitFromHostel}";
        }
        private string Random_Name_Generator()
        {
            string[] Names =
            {
                "Roman", "Sasha", "Vika", "Ira", "Mukola", "Elina",
                "Mia", "Volodya", "Erika", "Orest", "Vsevolod", "Edward"
            };
            string name = Names[random.Next(Names.Length)];
            return name;
        }
        private string Random_Surname_Generator()
        {
            string[] Surnames =
            {
                "Cholkan", "Smith", "Anderson",
                "Black", "Stone", "Arkenson", "Hilton"
            };
            string surname = Surnames[random.Next(Surnames.Length)];
            return surname;
        }
        private string Random_Group_Generator()
        {
            string[] Groups =
            {
                "VP31", "VP32", "KN22", "KN30", "KT22",
                "VP21", "VP13", "GT22", "UT30", "RT11"
            };
            string group = Groups[random.Next(Groups.Length)];
            return group;
        }
        public void RandomGenerator()
        {
            this.Name = Random_Name_Generator();
            this.Surname = Random_Surname_Generator();
            this.Group = Random_Group_Generator();
            this.Age = random.Next(17, 25);
            this.Hostel = random.Next(1, 3);
            this.TimeOfExitFromHostel.Hour = random.Next(8, 19);
            this.TimeOfExitFromHostel.Minute = random.Next(0, 61);
        }
        public void TimeOfWalking(string[] hostel1, string[] hostel2)
        {
            if (this.Hostel == 1)
            {
                TimeOfExitFromHostel.Hour += Convert.ToInt32(hostel1[0]);
                TimeOfExitFromHostel.Minute += Convert.ToInt32(hostel1[1]);
                if (TimeOfExitFromHostel.Minute >= 60)
                {
                    TimeOfExitFromHostel.Hour += TimeOfExitFromHostel.Minute / 60;
                    TimeOfExitFromHostel.Minute = TimeOfExitFromHostel.Minute % 60;
                }
            }
            else
            {
                TimeOfExitFromHostel.Hour += Convert.ToInt32(hostel2[0]);
                TimeOfExitFromHostel.Minute += Convert.ToInt32(hostel2[1]);
                if (TimeOfExitFromHostel.Minute >= 60)
                {
                    TimeOfExitFromHostel.Hour += TimeOfExitFromHostel.Minute / 60;
                    TimeOfExitFromHostel.Minute = TimeOfExitFromHostel.Minute % 60;
                }
            }
        }
    }
}
