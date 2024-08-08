using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2, num3;

            Console.WriteLine("Números pares existentes entre 1 e 50: ");
            for (num = 1; num < 51;  num++)
            {
                num2 = num % 2;
                if (num2 == 0)
                {
                    Console.WriteLine(num + " é par");
                }
            }
            Console.ReadKey();
        }
    }
}
