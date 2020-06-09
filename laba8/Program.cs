using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBSUIR st = new StudentBSUIR("Danila", "Prokopovich");

            StudentBSUIR.GoToArmyHandler goToArmyHandler1 = delegate (string msg)
            {
                Console.WriteLine(msg);
            };

            StudentBSUIR.GoToArmyHandler goToArmyHandler2 = (msg) => Console.WriteLine(msg);

            st.ArmyNotify += ShowMessage;
            st.ArmyNotify += goToArmyHandler1;
            st.ArmyNotify += goToArmyHandler2;

            //st.ArmyNotify -= ShowMessage;
            //st.ArmyNotify -= goToArmyHandler1;

            st.GoToArmy();

            StudentsFromBSUIR students = new StudentsFromBSUIR(2);
            students[0] = st;
            var st2 = new StudentBSUIR("Egor", "Kusovkov");
            students[1] = st2;
            for (int i = 0; i < 2; i++) 
            {
                students[i].AverageRating=(float)3.5+i;
            }
            Console.WriteLine("\nИх нужно отчислить");
            students.ShowStudents(x => x < 4);
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
