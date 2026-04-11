using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int c = 1;
            int r = 1;
            Console.WriteLine("Dimmi un numero e ti calcolero il fattoriale");
            n = Convert.ToInt32(Console.ReadLine());
            n += 1;
            for(;c < n; c++)
            {
                r *= c;
            }
            n -= 1;
            Console.WriteLine("Il fattoriale di {0} e: {1}", n, r);
            Console.ReadKey();
        }
    }
}
