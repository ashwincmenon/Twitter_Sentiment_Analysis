using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.Models
{
    public class student
    {
        public int rollno;
        public string name;

        public List<student> initStudent()
        {
            List<student> students = new List<student>();
            students.Add(new student() { rollno = 10, name = "jithin" });
            students.Add(new student() { rollno = 20, name = "ashwin" });
            students.Add(new student() { rollno = 30, name = "davis" });

            return students;
        }
    }
}