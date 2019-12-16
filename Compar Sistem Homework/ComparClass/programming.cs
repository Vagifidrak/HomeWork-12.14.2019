using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compar_Sistem_Homework.ComparClass
{
    class programming : Qruplar
    {
        public List<Student> StudentList;

        public programming(string proQroup) : base(proQroup){
           
            qroupName = proQroup;
            StList = new List<Student>();
            }
        

    }
}
