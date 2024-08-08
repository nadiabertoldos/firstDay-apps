using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aluno = new int[3];
            int[] materia_101 = new int[3];
            int[] materia_102 = new int[3];
            int[] materia_103 = new int[3];
            int i;
     
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o número do aluno");
                aluno[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota da mátéria 101");
                materia_101[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota da matéria 102");
                materia_102[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota da matéria 103");
                materia_103[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Alunos com nota maior que 5 na matéria 101");
            for (i = 0; i < 3; i++)
            {
                if (materia_101[i] > 5)
                {
                    Console.WriteLine("Aluno:" + aluno[i] + "Nota:" + materia_101[i]);
                }
            }

            Console.WriteLine("Alunos com nota maior que 5 na matéria 102");
            for (i = 0; i < 3; i++)
            {
                if (materia_102[i] > 7)
                {
                    Console.WriteLine("Aluno:" + aluno[i] + "Nota:" + materia_102[i]);
                }    
            }

            Console.WriteLine("Alunos com nota maior que 5 na matéria 103");
            for (i = 0; i < 3; i++)
            {
                if (materia_103[i] > 7)
                {
                    Console.WriteLine("Aluno:" + aluno[i] + "Nota:" + materia_103[i]);
                }                  
            }
            Console.ReadKey();
        }
    }
}
