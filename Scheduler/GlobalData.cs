using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    internal class GlobalData
    {
        public GlobalData()
        { 
            Teachers.Add(new Teacher("Alice") { TeacherId = 0 });
            Teachers[0].AddClass(ClassType.Math);
            Teachers[0].AddClass(ClassType.NO);
            Teachers.Add(new Teacher("Bob") { TeacherId = 1 });
            Teachers[1].AddClass(ClassType.Swedish);
            Teachers[1].AddClass(ClassType.SO);
            Teachers.Add(new Teacher("Charlie") { TeacherId = 2 });
            Teachers[2].AddClass(ClassType.Gym);
            Classes.Add(new classes("Math", 45, 5,5));
            Classes.Add(new classes("Swedish", 40, 5,5));
            Classes.Add(new classes("English", 50, 10,10));
            Classes.Add(new classes("Gym", 60, 20,20));
        }

        public static List<Teacher> Teachers = new List<Teacher>();
        public static List<classes> Classes = new List<classes>();
        public static List<classes> OpenClasses = new List<classes>();


    }
}
