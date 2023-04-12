using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prj_Naval_31927
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Alvos player 1
            string[,] alvos1 = new string[3, 3];
            int indiceNumero = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int t = 0; t < 3; t++)
                {
                    indiceNumero++;
                    alvos1[i, t] = (indiceNumero).ToString();
                }
            }
            
            #endregion
            #region Alvos player 2
            string[,] alvos2 = new string[3, 3];
            indiceNumero = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int t = 0; t < 3; t++)
                {
                    indiceNumero++;
                    alvos2[i, t] = (indiceNumero).ToString();
                }
            }
            #endregion
            string escolhaback;

            #region Alvos Background Player 1
            string[,] alvos1back = new string [3, 3];
            indiceNumero = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int t = 0; t < 3; t++)
                {
                    indiceNumero++;
                    alvos1back[i, t] = (indiceNumero).ToString();
                }
            }
            
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("(Player 1) Escolha o lugar de seus navios");
                escolhaback = Console.ReadLine();
                switch(escolhaback)
                {
                    case "1":
                        {
                            alvos1back[0, 0] = "N";
                            break;
                        }
                    case "2":
                        {
                            alvos1back[0, 1] = "N";
                            break;
                        }
                    case "3":
                        {
                            alvos1back[0, 2] = "N";
                            break;
                        }
                    case "4":
                        {
                            alvos1back[1, 0] = "N";
                            break;
                        }
                    case "5":
                        {
                            alvos1back[1, 1] = "N";
                            break;
                        }
                    case "6":
                        {
                            alvos1back[1, 2] = "N";
                            break;
                        }
                    case "7":
                        {
                            alvos1back[2, 0] = "N";
                            break;
                        }
                    case "8":
                        {
                            alvos1back[2, 1] = "N";
                            break;
                        }
                    case "9":
                        {
                            alvos1back[2, 2] = "N";
                            break;
                        }
                }
            }
            #endregion
            #region Alvos Background player 2
            string[,] alvos2back = new string[3, 3];
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("(Player 2) Escolha o lugar de seus navios");
                escolhaback = Console.ReadLine();
                switch (escolhaback)
                {
                    case "1":
                        {
                            alvos2back[0, 0] = "N";
                            break;
                        }
                    case "2":
                        {
                            alvos2back[0, 1] = "N";
                            break;
                        }
                    case "3":
                        {
                            alvos2back[0, 2] = "N";
                            break;
                        }
                    case "4":
                        {
                            alvos2back[1, 0] = "N";
                            break;
                        }
                    case "5":
                        {
                            alvos2back[1, 1] = "N";
                            break;
                        }
                    case "6":
                        {
                            alvos2back[1, 2] = "N";
                            break;
                        }
                    case "7":
                        {
                            alvos2back[2, 0] = "N";
                            break;
                        }
                    case "8":
                        {
                            alvos2back[2, 1] = "N";
                            break;
                        }
                    case "9":
                        {
                            alvos2back[2, 2] = "N";
                            break;
                        }
                }
            }
            #endregion

            #region Player
            int p = 0;
            string escolha;
            #endregion
            #region Jogo
            
            for (int i = 0; i <= 99; i++)
            {
                #region Mostrar campo
                Console.WriteLine("Player 1\t\t\t\t\tPlayer 2");
                Console.WriteLine(alvos1[0, 0] + "\t" + alvos1[0, 1] + "\t" + alvos1[0, 2] + "\t \t \t \t"+ alvos2[0, 0] + "\t" + alvos2[0, 1] + "\t" + alvos2[0, 2]);
                Console.WriteLine(alvos1[1, 0] + "\t" + alvos1[1, 1] + "\t" + alvos1[1, 2] + "\t \t \t \t" + alvos2[1, 0] + "\t" + alvos2[1, 1] + "\t" + alvos2[1, 2]);
                Console.WriteLine(alvos1[2, 0] + "\t" + alvos1[2, 1] + "\t" + alvos1[2, 2] + "\t \t \t \t" + alvos2[2, 0] + "\t" + alvos2[2, 1] + "\t" + alvos2[2, 2]);
                #endregion
                #region Escolha Player
                Console.WriteLine("Player " + (p+1) + " escolhe");
                escolha = Console.ReadLine();
                #endregion
                #region Verifica Escolha Player 1
                if (p == 0)
                {
                    indiceNumero = 0;
                    for (int s = 0; s < 3; s++)
                    {
                        for (int t = 0; t < 3; t++)
                        {
                            if(escolha == alvos2[s,t])
                            {
                                if (alvos2back[s, t] == "N")
                                {
                                    alvos2[s, t] = "N";
                                    break;
                                }
                                else
                                {
                                    alvos2[s, t] = "X";
                                    break;
                                }
                            }
                        }
                    }
                }
                #endregion
                #region Verifica Escolha Player 2
                if (p == 1)
                {
                    indiceNumero = 0;
                    for (int s = 0; s < 3; s++)
                    {
                        for (int t = 0; t < 3; t++)
                        {
                            if (escolha == alvos1[s, t])
                            {
                                if (alvos1back[s, t] == "N")
                                {
                                    alvos1[s, t] = "N";
                                    break;
                                }
                                else
                                {
                                    alvos1[s, t] = "X";
                                    break;
                                }
                            }
                        }
                    }
                }
                #endregion
                #region Verifica Proximo Player
                if (p == 0)
                {
                    p = 1;
                }
                else
                {
                    if (p == 1)
                    {
                        p = 0;
                    }
                }
                #endregion
                Console.Clear();
                #region Possibilidades de ganhar Player 1
                if (p == 1)
                {
                    int targetDowns = 0;
                    indiceNumero = 0;
                    for (int s = 0; s < 3; s++)
                    {
                        for (int t = 0; t < 3; t++)
                        {
                            if (alvos2[s, t] == "N")
                            {
                                targetDowns++;
                                if(targetDowns == 3)
                                {
                                    Console.WriteLine("Player 1 Ganhou!!");
                                    Console.ReadKey();
                                    return;
                                }
                            }
                        }
                    }
                }
                #endregion
                #region Possibilidades de ganhar Player 2
                if (p == 0)
                {
                    int targetDowns = 0;
                    indiceNumero = 0;
                    for (int s = 0; s < 3; s++)
                    {
                        for (int t = 0; t < 3; t++)
                        {
                            if (alvos1[s, t] == "N")
                            {
                                targetDowns++;
                                if (targetDowns == 3)
                                {
                                    Console.WriteLine("Player 2 Ganhou!!");
                                    Console.ReadKey();
                                    return;
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            #endregion
        }
    }
}
