﻿using System;
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

        public String SearchByName(string name)
        {
            return "Searched By Name";
        }
    }
}