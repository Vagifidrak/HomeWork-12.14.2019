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
            Console.OutputEncoding = Encoding.UTF8;


            int inpreqem;
            Console.WriteLine("Yalniz asagidaki reqemlerden birini daxil edin");

            do
            {
                Console.WriteLine("1.Telebeleri elave edin");
                Console.WriteLine("2.Telebeleri secin ve imtahan elave edin");
                Console.WriteLine("3.Imtahan listi");
                Console.WriteLine("4.Cixis");
                Console.WriteLine(">>>>>>>>>>>>>>");

                String userInput = Console.ReadLine();
                if (int.TryParse(userInput, out inpreqem))
                {
                    switch (inpreqem)
                    {
                        case 1:
                            Console.WriteLine("Telebe yaradildi");
                            break;
                        case 2:
                            Console.WriteLine("Imtahan daxil edildi");
                            break;
                        case 3:
                            Console.WriteLine("Imtaha listine bax");
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Zehmet olmasa 1-4 arasinda reqem daxil edin");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa reqem daxil edin");
                }
            } while (inpreqem != 4);
        }
    }
}
