using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compar_Sistem_Homework.ComparClass
{
    class Student
    {
        public string FullName;
        public int age;
        private static int stuId=0;
        public Student(string fname, int age)
        {
            FullName = fname;
            this.age = age;
            stuId++;
            Console.WriteLine(stuId);
        }
    }
}
