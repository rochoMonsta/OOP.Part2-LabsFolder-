using System;
using System.Linq;

namespace Lab3
{
    static class StudentHelper
    {
        public static Student StudentRandomGenerator(this Student student)
        {
            Random random = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));

            string[] Names =
            {
                "Roman", "Sasha", "Vika", "Ira", "Mukola", "Elina",
                "Mia", "Volodya", "Erika", "Orest", "Vsevolod", "Edward"
            };
            string[] Surnames =
            {
                "Cholkan", "Smith", "Anderson",
                "Black", "Stone", "Arkenson", "Hilton"
            };
            string[] Groups =
            {
                "VP31", "VP32", "KN22", "KN30", "KT22",
                "VP21", "VP13", "GT22", "UT30", "RT11"
            };

            student.Name = Names[random.Next(Names.Length)];
            student.Surname = Surnames[random.Next(Surnames.Length)];
            student.Age = random.Next(17, 25);
            student.Group = Groups[random.Next(Groups.Length)];

            return student;
        }
    }
}