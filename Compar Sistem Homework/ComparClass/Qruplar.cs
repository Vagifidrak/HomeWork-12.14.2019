using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compar_Sistem_Homework.ComparClass
{
   abstract class Qruplar
    {
        public string qroupName;
        public List<Student> StList;
        


        public Qruplar(string qroupName)
        {
            StList = new List<Student>();
            this.qroupName = qroupName;
        }
        
   }
}
