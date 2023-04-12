using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prj_minado_31927
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[,] alvos = new string[3, 3];
            #region alvos
            for (int i = 0; i < 3; i++)
            {
                for (int t = 0; t < 3; t++)
                {
                    alvos[i, t] = "O";
                }
            }
            #endregion
            string[,] alvosback = new string[3, 3];
            int linha, coluna;
            #region alvos minados
            for (int i = 0; i < 3; i++)
            {
                int x;
                int y;
                do
                {
                    x = rand.Next(0, 3);
                    y = rand.Next(0, 3);

                } while (alvosback[x, y] == "X");
                if (alvosback[x, y] == null)
                {
                    alvosback[x, y] = "X";
                }
            }
            #endregion
            Console.WriteLine(alvos[0, 0] + "\t" + alvos[0, 1] + "\t" + alvos[0, 2]);
            Console.WriteLine(alvos[1, 0] + "\t" + alvos[1, 1] + "\t" + alvos[1, 2]);
            Console.WriteLine(alvos[2, 0] + "\t" + alvos[2, 1] + "\t" + alvos[2, 2]);
            #region jogo
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Escolha uma linha");
                linha = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha uma coluna");
                coluna = int.Parse(Console.ReadLine());
                if (alvosback[linha, coluna] == "X")
                {
                    Console.WriteLine("MORREU");
                    Console.ReadKey();
                    return;
                }
                alvos[linha, coluna] = "X";
                Console.Clear();
                Console.WriteLine(alvos[0, 0] + "\t" + alvos[0, 1] + "\t" + alvos[0, 2]);
                Console.WriteLine(alvos[1, 0] + "\t" + alvos[1, 1] + "\t" + alvos[1, 2]);
                Console.WriteLine(alvos[2, 0] + "\t" + alvos[2, 1] + "\t" + alvos[2, 2]);
                
            }
            #endregion
        }
    }
}
