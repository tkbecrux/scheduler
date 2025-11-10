namespace Scheduler
{
 enum ClassType
    {
        Math,
        Swedish,
        English,
        Gym,
        SO,
        NO,
    }
    partial class classes
    {
        private int classLength;
        private string className;
        private int teacherId;
        private int timeBefore;
        private int timeAfter;
        public classes(string name, int length, int before, int after)
        {
            className = name;
            classLength = length;
            timeBefore = before;
            timeAfter = after;
        }

        public string getName()
        {
            return className;
        }

        public int getLength()
        {
            return classLength;
        }

        public void setTeacherId(int id)
        {
            teacherId = id;
        }

        public int getTeacherId()
        {
            return teacherId;
        }

        public void setTimeBefore(int time)
        {
            timeBefore = time;
        }

        public int getTimeBefore()
        {
            return timeBefore;
        }

        public void setTimeAfter(int time)
        {
            timeAfter = time;
        }

        public int getTimeAfter()
        {
            return timeAfter;
        }
    }
}