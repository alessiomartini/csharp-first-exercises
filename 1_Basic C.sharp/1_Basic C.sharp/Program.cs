using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Basic_C.sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello World";
            int x = 0;
            Console.WriteLine(hello);
            string a = Console.ReadLine();
            Console.WriteLine(a);
            Console.ReadKey();
            while(x!=100)
            {
                
                x += 2;
                if(x>20 && x < 60)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey();
        }
    }
}
