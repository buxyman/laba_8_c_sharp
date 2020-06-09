using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StudentsFromBSUIR : StudentBSUIR
    {
        StudentBSUIR[] students;

        public StudentsFromBSUIR(int amount)
        {
            students = new StudentBSUIR[amount];
        }

        public StudentBSUIR this[int index]
        {
            get=> students[index];
            
            set=> students[index] = value;
           
        }

        public delegate bool MarkCondition(float x);

        public void ShowStudents(MarkCondition condition)
        {
            foreach (StudentBSUIR st in students)
            {
                if (condition(st.AverageRating))
                {
                    Console.WriteLine($"{st.Name} - {st.AverageRating}");
                }
            }
        }

        public void ShowStudents()
        {
            foreach (StudentBSUIR st in students)
            {
                Console.WriteLine($"{st.Name} - {st.AverageRating}");
            }
        }
    }

}
