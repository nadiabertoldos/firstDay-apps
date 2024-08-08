using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestLog
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c = 0;
            int d = 0;

            do
            {
                Console.WriteLine("Digite dois números");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a % b;
                d = d + 1;
                Console.Clear();
            } while (c != 0);

            Console.WriteLine("Há " + d + " números divisíveis");
            Thread.Sleep(5000); // Pausar por 5 segundos (5000 milissegundos)
        }
    }
}
