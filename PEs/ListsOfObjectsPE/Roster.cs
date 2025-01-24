﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListsOfObjectsPE
{
    internal class Roster
    {
        private string name;
        private List<Student> students;
        private string filename;

        public Roster(string name)
        {
            this.name = name;
            students = new List<Student>();

            // Use the provided roster name as a potential filename (e.g. “All Students.txt” with the correct relative path)
            filename = "../../../"+name + ".txt";

            // and check if it exists using the .NET File class.

            // IF the file exists, use it to populate the roster List
            // (by reading it based on the file format you used in Save)

            // If it doesn’t exist, do nothing extra. The constructor finishes
            // with an empty students List just as it did before.

        }

        public void Save()
        {
            // Uses object’s roster name as a potential filename
            // (e.g. “All Students.txt” with the correct relative path)
            // and writes all students to the file (in a format of your choice).

            // Create the variable here since we need it
            // after the try
            StreamWriter writer = null;

            try
            {
                // When we open for writing, create
                // the file if it doesn't exist yet
                writer = new StreamWriter(filename);

                // Write some data
                /*
                writer.Write("Hello ");
                writer.WriteLine("there!");
                writer.WriteLine("This works!");
                */

                // Write student data
                // name@major@year
                foreach (Student s in students)
                {
                    writer.WriteLine($"{s.Name}@{s.Major}@{s.Year}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error writing: " + e.Message);
            }

            // just for demo purpose
            //SmartConsole.Prompt("Press enter to continue.");

            // Close it as long as it was actually opened
            if (writer != null)
            {
                writer.Close();
            }

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
