using System.Collections.Generic;

namespace Lab1
{
    class Sort
    {
        public void BubleSort(List<Student> students_list)
        {
            for (int i = 0; i < students_list.Count; ++i)
            {
                for (int j = 0; j < students_list.Count - 1; ++j)
                {
                    if (students_list[j].TimeOfExitFromHostel.TickTime() > students_list[j + 1].TimeOfExitFromHostel.TickTime())
                    {
                        Student fake_student = students_list[j];
                        students_list[j] = students_list[j + 1];
                        students_list[j + 1] = fake_student;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        public void ShellaSort(List<Student> students_list)
        {
            var d = students_list.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < students_list.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && (students_list[j - d].TimeOfExitFromHostel.TickTime() > students_list[j].TimeOfExitFromHostel.TickTime()))
                    {
                        Student fake_student = students_list[j];
                        students_list[j] = students_list[j - d];
                        students_list[j - d] = fake_student;
                        j = j - d;
                    }
                }
                d = d / 2;
            }
        }
    }
}
