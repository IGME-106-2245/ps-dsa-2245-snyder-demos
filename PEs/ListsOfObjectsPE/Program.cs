﻿namespace ListsOfObjectsPE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student test = new Student("Shiro", "Cooking", 4);
            Console.WriteLine(test);
            TestRoster();
        }

        private static void TestRoster()
        {
            Roster roster = new Roster("Sample");
            roster.AddStudent(new Student("Shiro", "Cooking", 4));
            roster.AddStudent(new Student("Lacy", "Baking", 3));
            roster.AddStudent(new Student("Pax", "Barking", 2));
            roster.AddStudent(new Student("Aiden", "Eating", 1));
        }
    }
}
