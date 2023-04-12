using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace batalhanaval32313
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[10, 10];
            string[,] navios = new string[10, 10];

            string[] letras = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

            Random rand = new Random();
            Ferramentas ferramentas = new Ferramentas();

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    matriz[x, y] = letras[x] + (y + 1);
                }
            }


            for (int i = 0; i < 5; i++)
            {
                int x = rand.Next(0,10);
                int y = rand.Next(0,10);
                if (navios[x, y] == null)
                {
                    navios[x, y] = "H";
                }
            }

            for (int i = 0; i < 4; i++)
            {
                int x;
                int y;
                int[] pos1Actual = new int[2];
                do
                {
                    x = rand.Next(1, 9);
                    y = rand.Next(1, 9);
                    pos1Actual = ferramentas.Check2Position(x,y,navios);
                } while (pos1Actual[0] == 0 && pos1Actual[1] == 0);
                navios[x, y] = "S";
                navios[pos1Actual[0], pos1Actual[1]] = "S";
            }

            for (int i = 0; i < 3; i++)
            {
                int x;
                int y;
                int[,] posActual = new int[2,2];
                do
                {
                    x = rand.Next(1, 9);
                    y = rand.Next(1, 9);
                    posActual = ferramentas.CheckCruzadoPosition(x, y, navios);
                } while (posActual[0,0] == 0 && posActual[1,0] == 0 && posActual[2, 0] == 0 && posActual[3, 0] == 0);
                navios[x, y] = "C";
                navios[posActual[0,0], posActual[1,0]] = "C";
                navios[posActual[2, 0], posActual[3, 0]] = "C";
            }

            for (int i = 0; i < 2; i++)
            {
                int x;
                int y;
                int[,] posActual = new int[2, 2];
                do
                {
                    x = rand.Next(1, 9);
                    y = rand.Next(1, 9);
                    posActual = ferramentas.CheckEncouPosition(x, y, navios);
                } while (posActual[0, 0] == 0 && posActual[1, 0] == 0 && posActual[2, 0] == 0 && posActual[3, 0] == 0 && posActual[4, 0] == 0 && posActual[5, 0] == 0);
                navios[x, y] = "E";
                navios[posActual[0, 0], posActual[1, 0]] = "E";
                navios[posActual[2, 0], posActual[3, 0]] = "E";
                navios[posActual[4, 0], posActual[5, 0]] = "E";
            }

            for (int i = 0; i < 1; i++)
            {
                int x;
                int y;
                int[,] posActual = new int[2,2];
                do
                {
                    x = rand.Next(1, 9);
                    y = rand.Next(1, 9);
                    posActual = ferramentas.CheckPortaAviaoPosition(x, y, navios);
                } while (posActual[0, 0] == 0 && posActual[1, 0] == 0 && posActual[2, 0] == 0 && posActual[3, 0] == 0 && posActual[4, 0] == 0 && posActual[5, 0] == 0);
                navios[x, y] = "P";
                navios[posActual[0,0], posActual[1,0]] = "P";
                navios[posActual[2, 0], posActual[3, 0]] = "P";
                navios[posActual[4, 0], posActual[5, 0]] = "P";
            }


            int chance = 3;
            int targetsDown = 0;
            //Tabela!
            
            do
            { 
                Console.WriteLine("\t " + 1 + "\t" + 2 + "\t" + 3 + "\t" + 4 + "\t" + 5 + "\t" + 6 + "\t" + 7 + "\t" + 8 + "\t" + 9 + "\t" + 10);
                Console.WriteLine(" ");
                Console.Write("A\t");
                Console.WriteLine(matriz[0, 0] + "\t" + matriz[0, 1] + "\t" + matriz[0, 2] + "\t" + matriz[0, 3] + "\t" + matriz[0, 4] + "\t" + matriz[0, 5] + "\t" + matriz[0, 6] + "\t" + matriz[0, 7] + "\t" + matriz[0, 8] + "\t" + matriz[0, 9]);
                Console.Write("B\t");
                Console.WriteLine(matriz[1, 0] + "\t" + matriz[1, 1] + "\t" + matriz[1, 2] + "\t" + matriz[1, 3] + "\t" + matriz[1, 4] + "\t" + matriz[1, 5] + "\t" + matriz[1, 6] + "\t" + matriz[1, 7] + "\t" + matriz[1, 8] + "\t" + matriz[1, 9]);
                Console.Write("C\t");
                Console.WriteLine(matriz[2, 0] + "\t" + matriz[2, 1] + "\t" + matriz[2, 2] + "\t" + matriz[2, 3] + "\t" + matriz[2, 4] + "\t" + matriz[2, 5] + "\t" + matriz[2, 6] + "\t" + matriz[2, 7] + "\t" + matriz[2, 8] + "\t" + matriz[2, 9]);
                Console.Write("D\t");
                Console.WriteLine(matriz[3, 0] + "\t" + matriz[3, 1] + "\t" + matriz[3, 2] + "\t" + matriz[3, 3] + "\t" + matriz[3, 4] + "\t" + matriz[3, 5] + "\t" + matriz[3, 6] + "\t" + matriz[3, 7] + "\t" + matriz[3, 8] + "\t" + matriz[3, 9]);
                Console.Write("E\t");
                Console.WriteLine(matriz[4, 0] + "\t" + matriz[4, 1] + "\t" + matriz[4, 2] + "\t" + matriz[4, 3] + "\t" + matriz[4, 4] + "\t" + matriz[4, 5] + "\t" + matriz[4, 6] + "\t" + matriz[4, 7] + "\t" + matriz[4, 8] + "\t" + matriz[4, 9]);
                Console.Write("F\t");
                Console.WriteLine(matriz[5, 0] + "\t" + matriz[5, 1] + "\t" + matriz[5, 2] + "\t" + matriz[5, 3] + "\t" + matriz[5, 4] + "\t" + matriz[5, 5] + "\t" + matriz[5, 6] + "\t" + matriz[5, 7] + "\t" + matriz[5, 8] + "\t" + matriz[5, 9]);
                Console.Write("G\t");
                Console.WriteLine(matriz[6, 0] + "\t" + matriz[6, 1] + "\t" + matriz[6, 2] + "\t" + matriz[6, 3] + "\t" + matriz[6, 4] + "\t" + matriz[6, 5] + "\t" + matriz[6, 6] + "\t" + matriz[6, 7] + "\t" + matriz[6, 8] + "\t" + matriz[6, 9]);
                Console.Write("H\t");
                Console.WriteLine(matriz[7, 0] + "\t" + matriz[7, 1] + "\t" + matriz[7, 2] + "\t" + matriz[7, 3] + "\t" + matriz[7, 4] + "\t" + matriz[7, 5] + "\t" + matriz[7, 6] + "\t" + matriz[7, 7] + "\t" + matriz[7, 8] + "\t" + matriz[7, 9]);
                Console.Write("I\t");
                Console.WriteLine(matriz[8, 0] + "\t" + matriz[8, 1] + "\t" + matriz[8, 2] + "\t" + matriz[8, 3] + "\t" + matriz[8, 4] + "\t" + matriz[8, 5] + "\t" + matriz[8, 6] + "\t" + matriz[8, 7] + "\t" + matriz[8, 8] + "\t" + matriz[8, 9]);
                Console.Write("J\t");
                Console.WriteLine(matriz[9, 0] + "\t" + matriz[9, 1] + "\t" + matriz[9, 2] + "\t" + matriz[9, 3] + "\t" + matriz[9, 4] + "\t" + matriz[9, 5] + "\t" + matriz[9, 6] + "\t" + matriz[9, 7] + "\t" + matriz[9, 8] + "\t" + matriz[9, 9]);
                
                Console.WriteLine("\nDigite uma posição ");
                string escolha = Console.ReadLine();

                for (int l = 0; l <= 9; l++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        if (escolha == matriz[l, c])
                        {
                            switch(navios[l,c])
                            {
                                case "H":
                                    {
                                        Console.WriteLine("Você acertou um Hidroavião!!");
                                        Console.ReadKey();
                                        matriz[l, c] = "H";
                                        chance = 3;
                                        targetsDown++;
                                        break;
                                    }
                                case "S":
                                    {
                                        Console.WriteLine("Você acertou um Submarino!!");
                                        Console.ReadKey();
                                        matriz[l, c] = "S";
                                        chance = 3;
                                        targetsDown++;
                                        break;
                                    }
                                case "E":
                                    {
                                        Console.WriteLine("Você acertou um Encouraçado!!");
                                        Console.ReadKey();
                                        matriz[l, c] = "E";
                                        chance = 3;
                                        targetsDown++;
                                        break;
                                    }
                                case "P":
                                    {
                                        Console.WriteLine("Você acertou um Porta Avião!!");
                                        Console.ReadKey();
                                        matriz[l, c] = "P";
                                        targetsDown++;
                                        chance = 3;
                                        break;
                                    }
                                default:
                                    {
                                        chance = chance - 1;
                                        Console.WriteLine("Você atingiu a água! Voce tem mais {0} chances", chance);
                                        Console.ReadKey();
                                        matriz[l, c] = "X";
                                        break;
                                    }
                            }
                            
                        }
  
                    }
                }
                
                Console.Clear();

            }while(chance > 0 || targetsDown >= 34);


            if (targetsDown >= 34)
            {
                Console.Clear();
                Console.WriteLine("Você venceu!! Parabéns!!!");
                Console.ReadKey();

                Console.WriteLine("\t " + 1 + "\t" + 2 + "\t" + 3 + "\t" + 4 + "\t" + 5 + "\t" + 6 + "\t" + 7 + "\t" + 8 + "\t" + 9 + "\t" + 10);
                Console.WriteLine(" ");
                Console.Write("A\t");
                Console.WriteLine(matriz[0, 0] + "\t" + matriz[0, 1] + "\t" + matriz[0, 2] + "\t" + matriz[0, 3] + "\t" + matriz[0, 4] + "\t" + matriz[0, 5] + "\t" + matriz[0, 6] + "\t" + matriz[0, 7] + "\t" + matriz[0, 8] + "\t" + matriz[0, 9]);
                Console.Write("B\t");
                Console.WriteLine(matriz[1, 0] + "\t" + matriz[1, 1] + "\t" + matriz[1, 2] + "\t" + matriz[1, 3] + "\t" + matriz[1, 4] + "\t" + matriz[1, 5] + "\t" + matriz[1, 6] + "\t" + matriz[1, 7] + "\t" + matriz[1, 8] + "\t" + matriz[1, 9]);
                Console.Write("C\t");
                Console.WriteLine(matriz[2, 0] + "\t" + matriz[2, 1] + "\t" + matriz[2, 2] + "\t" + matriz[2, 3] + "\t" + matriz[2, 4] + "\t" + matriz[2, 5] + "\t" + matriz[2, 6] + "\t" + matriz[2, 7] + "\t" + matriz[2, 8] + "\t" + matriz[2, 9]);
                Console.Write("D\t");
                Console.WriteLine(matriz[3, 0] + "\t" + matriz[3, 1] + "\t" + matriz[3, 2] + "\t" + matriz[3, 3] + "\t" + matriz[3, 4] + "\t" + matriz[3, 5] + "\t" + matriz[3, 6] + "\t" + matriz[3, 7] + "\t" + matriz[3, 8] + "\t" + matriz[3, 9]);
                Console.Write("E\t");
                Console.WriteLine(matriz[4, 0] + "\t" + matriz[4, 1] + "\t" + matriz[4, 2] + "\t" + matriz[4, 3] + "\t" + matriz[4, 4] + "\t" + matriz[4, 5] + "\t" + matriz[4, 6] + "\t" + matriz[4, 7] + "\t" + matriz[4, 8] + "\t" + matriz[4, 9]);
                Console.Write("F\t");
                Console.WriteLine(matriz[5, 0] + "\t" + matriz[5, 1] + "\t" + matriz[5, 2] + "\t" + matriz[5, 3] + "\t" + matriz[5, 4] + "\t" + matriz[5, 5] + "\t" + matriz[5, 6] + "\t" + matriz[5, 7] + "\t" + matriz[5, 8] + "\t" + matriz[5, 9]);
                Console.Write("G\t");
                Console.WriteLine(matriz[6, 0] + "\t" + matriz[6, 1] + "\t" + matriz[6, 2] + "\t" + matriz[6, 3] + "\t" + matriz[6, 4] + "\t" + matriz[6, 5] + "\t" + matriz[6, 6] + "\t" + matriz[6, 7] + "\t" + matriz[6, 8] + "\t" + matriz[6, 9]);
                Console.Write("H\t");
                Console.WriteLine(matriz[7, 0] + "\t" + matriz[7, 1] + "\t" + matriz[7, 2] + "\t" + matriz[7, 3] + "\t" + matriz[7, 4] + "\t" + matriz[7, 5] + "\t" + matriz[7, 6] + "\t" + matriz[7, 7] + "\t" + matriz[7, 8] + "\t" + matriz[7, 9]);
                Console.Write("I\t");
                Console.WriteLine(matriz[8, 0] + "\t" + matriz[8, 1] + "\t" + matriz[8, 2] + "\t" + matriz[8, 3] + "\t" + matriz[8, 4] + "\t" + matriz[8, 5] + "\t" + matriz[8, 6] + "\t" + matriz[8, 7] + "\t" + matriz[8, 8] + "\t" + matriz[8, 9]);
                Console.Write("J\t");
                Console.WriteLine(matriz[9, 0] + "\t" + matriz[9, 1] + "\t" + matriz[9, 2] + "\t" + matriz[9, 3] + "\t" + matriz[9, 4] + "\t" + matriz[9, 5] + "\t" + matriz[9, 6] + "\t" + matriz[9, 7] + "\t" + matriz[9, 8] + "\t" + matriz[9, 9]);

                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.Write("Voce perdeu");
                Console.ReadKey();
            }
            
            
        }

    }

    
}
