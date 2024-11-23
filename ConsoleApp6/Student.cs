using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Student
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public List<int> Marks { get; set; }
        public Student(string name, List<Course> courses, List<int> marks)
        {
            Name = name;
            Courses = courses;
            Marks = marks;
        }
        public void AddCourse(Course course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
                course.Add(this); 
            }
        }

        public void AddMark(int mark)
        {
            Marks.Add(mark);
        }

        public double ShowAverageGrade() => Marks.Count > 0 ? Marks.Average() : 0;
    }
}
