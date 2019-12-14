using Compar_Sistem_Homework.ComparClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compar_Sistem_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            do {
                Console.WriteLine("1.Yeni Qrup yarat:");
                Console.WriteLine("2.Yeni Telebe yarat:");
                Console.WriteLine("3.Telebelerin siyahisi:");
                Console.WriteLine("4.Mellimlerin siyahisi:");
                Console.WriteLine("5.Proqramdan cixis");
                userInput = Convert.ToInt32(Console.ReadLine());
                try
                {

                }
            } while (userInput !=5);
        }
    }
}
