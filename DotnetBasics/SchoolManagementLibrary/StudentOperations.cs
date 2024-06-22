using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementLibrary
{
    public class StudentOperations
    {
       public static List<Student> studentList = new List<Student>(); //its a generic list of type student

        static StudentOperations()
        {
            studentList.Add(new Student(rno: 1, city: "Pune", name: "Pallavi"));

            studentList.Add(new Student(2, "Kajal", "Nashik"));

            studentList.Add(new Student(3, "Shreya", "Bangalor"));
        }
        public void AddStudent(Student student)
        {
            //Student s = new Student(rno:student.RollNo, name:student.StudentName, city:student.City);
            
            Student s = new Student();
            s.RollNo = student.RollNo;
            s.StudentName = student.StudentName;
            s.City = student.City;
            studentList.Add(s);
           
        }
        public void UpdatedStudent(Student student)
        {

        }
        public void DeleteStudent(Student student)
        {

        }
        public List<Student> GetStudent()
        {
            return studentList;
        }
    }

  
}
