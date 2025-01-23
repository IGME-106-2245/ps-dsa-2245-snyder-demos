using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsOfObjectsPE
{
    internal class Student
    {
        private string name;
        private string major;
        private int year;

        public String Name
        {
            get { return name; }
        }

        public String Major
        {
            get { return major; }
        }

        public int Year
        {
            get { return year; }
        }

        public Student(String name, String major, int year)
        {
            this.name = name;
            this.major = major;
            this.year = year;
        }

        public override String ToString()
        {
            return String.Format($"{Name} - {Year} - {Major}");
        }
    }
}
