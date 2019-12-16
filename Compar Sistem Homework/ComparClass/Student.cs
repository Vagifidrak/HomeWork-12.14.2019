using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compar_Sistem_Homework.ComparClass
{
    class Student
    {
        public string Fullname { get; set; }
        private static int stuId = 0;
        public int age;
        Student newStudent;

        public Student (string fname, int age)
            {
                Fullname = fname;
                this.age = age;
                stuId++;
                Console.WriteLine(stuId);
        }
        public void AddStudent()
        {
            Console.WriteLine("Telebe adini daxil edin:");
            string userInp = Console.ReadLine();
            newStudent = new Student (userInp,20);
            studentList.Add(newStudent);
            Console.WriteLine("Yeni telebe ugurla elave edildi");

        }
    }
    
}
