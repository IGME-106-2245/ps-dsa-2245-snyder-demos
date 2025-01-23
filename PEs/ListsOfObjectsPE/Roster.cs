using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsOfObjectsPE
{
    internal class Roster
    {
        private string name;
        private List<Student> students;

        public Roster(string name)
        {
            this.name = name;
            students = new List<Student>();
        }

        public Student SearchByName(string name)
        {
            // todo
            return null;
        }

        public void AddStudent(Student student)
        {
            // todo - make sure this student isn't already in the roster & print confirmation message
            // implementing the rest here only to allow for testing with the adding file support demo later
            students.Add(student);
        }

        public Student AddStudent()
        {
            // todo
            return null;
        }

        public void DisplayRoster()
        {

        }
    }
}
