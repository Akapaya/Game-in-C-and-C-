using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj_estante_31927
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] palavras = new string[3, 3];

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Escreva o objeto que vai aparecer no 0, "+ i);
                palavras[0, i] = Console.ReadLine();
            }
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Escreva o objeto que vai aparecer no 1, " + i);
                palavras[1, i] = Console.ReadLine();
            }
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Escreva o objeto que vai aparecer no 2, " + i);
                palavras[2, i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine(palavras[0, 0] + "\t" + palavras[0, 1] + "\t" + palavras[0, 2]);
            Console.WriteLine(palavras[1, 0] + "\t" + palavras[1, 1] + "\t" + palavras[1, 2]);
            Console.WriteLine(palavras[2, 0] + "\t" + palavras[2, 1] + "\t" + palavras[2, 2]);
            Console.ReadKey();
        }
    }
}
