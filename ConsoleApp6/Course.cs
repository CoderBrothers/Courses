using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Course
    {
        public string CourseName {  get; set; }
        public List<Student> Students { get; set; }
        public Course(string courseName, List<Student> students) 
        {
            CourseName = courseName;
            Students = students;
        }
        public void Add(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
                student.Courses.Add(this);
            }
        }

        ////public List<Student> ShowStudents()
        ////{
        ////    return Students;
        ////}

    }
}
