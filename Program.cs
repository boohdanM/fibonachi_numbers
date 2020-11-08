using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            
            string f = Console.ReadLine();
            int g = Convert.ToInt32(f, 10);
            int q;
            int e = 1;
            
            for (int i = g; i > 0; g--)
            {
                if (g>0)
                {
                    q = e;
                    e = e + q;
                    Console.WriteLine(e);
                }
                else
                { break; }

                Console.ReadLine();
            }
        }
    }
}
