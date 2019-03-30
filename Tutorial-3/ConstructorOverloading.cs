using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p2
{
    public class Student
    {
        string name, enrollment, branch;
        public Student(string name) {
            this.name = name;
        }
        public Student(string name, string enrollment) {
            this.name = name;
            this.enrollment = enrollment;
        }
        public Student(string name, string enrollment, string branch) {
            this.name = name;
            this.enrollment = enrollment;
            this.branch = branch;
        }
        public static void Main(String[] ar) {
            Student s1 = new Student("Parinay");
            Student s2 = new Student("Parinay","170473107009");
            Student s3 = new Student("Parinay","170473107009","CS");
        }
    }
}
