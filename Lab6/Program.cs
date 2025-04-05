using System;
using System.Collections.Generic;

namespace Lab_7
{
    class Teacher
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public double Salary { get; set; }

        public Teacher(string name, string id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }
    }

    class Course
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Teacher Teacher { get; set; }

        public Course(string name, string id, Teacher teacher)
        {
            Name = name;
            Id = id;
            Teacher = teacher;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public List<Course> Courses { get; set; }

        public Student(string name, string id)
        {
            Name = name;
            Id = id;
            Courses = new List<Course>();
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student ID: " + Id);
            Console.WriteLine("Enrolled Courses:");
            foreach (var course in Courses)
            {
                Console.WriteLine("  Course Name: " + course.Name);
                Console.WriteLine("  Course ID: " + course.Id);
                Console.WriteLine("  Teacher Name: " + course.Teacher.Name);
                Console.WriteLine("  Teacher ID: " + course.Teacher.Id);
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Teacher teacher1 = new Teacher("Nazia Alfaz", "T001", 50000);
            Teacher teacher2 = new Teacher("Kazi Sadia", "T002", 55000);

            
            Course course1 = new Course("IP", "C101", teacher1);
            Course course2 = new Course("OOP1", "C102", teacher2);
            Course course3 = new Course("OOP2", "C103", teacher2);



            List<Course> availableCourses = new List<Course> { course1, course2 };

            
            Console.WriteLine("Enter Student Name:");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter Student ID:");
            string studentId = Console.ReadLine();

            
            Student student = new Student(studentName, studentId);

            
            Console.WriteLine("Available Courses:");
            for (int i = 0; i < availableCourses.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + availableCourses[i].Name + " (ID: " + availableCourses[i].Id + ")");
            }

            Console.WriteLine("Enter the number of courses to enroll:");
            int courseCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < courseCount; i++)
            {
                Console.WriteLine("Enter the number corresponding to the course:");
                int courseChoice = int.Parse(Console.ReadLine()) - 1;

                if (courseChoice >= 0 && courseChoice < availableCourses.Count)
                {
                    student.Courses.Add(availableCourses[courseChoice]);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    i--;
                }
            }
            student.DisplayInfo();
        }
    }
}
