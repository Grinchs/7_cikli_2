using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _7_cikli_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cik reizes pārbaudīt skaitļus? ");
            int parb = int.Parse(Console.ReadLine());

            for (int i = 0; i<parb; i++) {

                Console.WriteLine("Ievadiet skaitli: ");
                int x1 = int.Parse(Console.ReadLine());

                int dal1 = x1 % 3;

                if (dal1 == 0)
                {
                    Console.WriteLine("Skaitlis dalās bez atlikuma");
                }
                else
                {
                    Console.WriteLine("Skaitlis nedalās bez atlikuma");
                }
                           
            }
        }
    }

}
