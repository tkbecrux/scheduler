using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    internal class Teacher
    {
        public string Name { get; set; }
        public List<ClassType> Classes { get; set; }
        public Teacher(string name)
        {
            Name = name;
            Classes = new List<ClassType>();
        }

        public void AddClass(ClassType classType)
        {
            Classes.Add(classType);
        }

        public override string ToString()
        {
            return Name;
        }

        private int teacherId;
        public int TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }
    }
}
