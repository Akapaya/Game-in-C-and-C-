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
            int tiro = 3;
            string[,] Alvos = new string[10, 10];
            string[,] AlvosBack = new string[10, 10];
            #region AlvosBack
            #region Hidroavião
            AlvosBack[0, 2] = "H";
            AlvosBack[0, 7] = "H";
            AlvosBack[3, 8] = "H";
            AlvosBack[5, 1] = "H";
            AlvosBack[7, 0] = "H";
            #endregion
            #region Submarino
            AlvosBack[0,9] = "S";
            AlvosBack[1,9] ="S";

            AlvosBack[3, 3] = "S";
            AlvosBack[3, 4] = "S";

            AlvosBack[5, 3] = "S";
            AlvosBack[6, 3] = "S";

            AlvosBack[9, 1] = "S";
            AlvosBack[9, 2] = "S";
            #endregion
            #region Cruzadores
            AlvosBack[8, 4] = "C";
            AlvosBack[9, 4] = "C";
            AlvosBack[9, 5] = "C";

            AlvosBack[8, 8] = "C";
            AlvosBack[9, 8] = "C";
            AlvosBack[9, 7] = "C";

            AlvosBack[1, 0] = "C";
            AlvosBack[2, 0] = "C";
            AlvosBack[2, 1] = "C";
            #endregion
            #region Encoraçados
            AlvosBack[0, 4] = "E";
            AlvosBack[0, 5] = "E";
            AlvosBack[1, 4] = "E";
            AlvosBack[1, 5] = "E";

            AlvosBack[5, 8] = "E";
            AlvosBack[5, 9] = "E";
            AlvosBack[6, 8] = "E";
            AlvosBack[6, 9] = "E";
            #endregion
            #region Porta-Aviões
            AlvosBack[3, 6] = "P";
            AlvosBack[4, 6] = "P";
            AlvosBack[5, 6] = "P";
            AlvosBack[6, 6] = "P";
            AlvosBack[7, 6] = "P";
            #endregion
            #endregion
            #region Alvos
            Alvos[0, 0] = "A1";
            Alvos[0, 1] = "A2";
            Alvos[0, 2] = "A3";
            Alvos[0, 3] = "A4";
            Alvos[0, 4] = "A5";
            Alvos[0, 5] = "A6";
            Alvos[0, 6] = "A7";
            Alvos[0, 7] = "A8";
            Alvos[0, 8] = "A9";
            Alvos[0, 9] = "A10";
            Alvos[1, 0] = "B1";
            Alvos[1, 1] = "B2";
            Alvos[1, 2] = "B3";
            Alvos[1, 3] = "B4";
            Alvos[1, 4] = "B5";
            Alvos[1, 5] = "B6";
            Alvos[1, 6] = "B7";
            Alvos[1, 7] = "B8";
            Alvos[1, 8] = "B9";
            Alvos[1, 9] = "B10";
            Alvos[2, 0] = "C1";
            Alvos[2, 1] = "C2";
            Alvos[2, 2] = "C3";
            Alvos[2, 3] = "C4";
            Alvos[2, 4] = "C5";
            Alvos[2, 5] = "C6";
            Alvos[2, 6] = "C7";
            Alvos[2, 7] = "C8";
            Alvos[2, 8] = "C9";
            Alvos[2, 9] = "C10";
            Alvos[3, 0] = "D1";
            Alvos[3, 1] = "D2";
            Alvos[3, 2] = "D3";
            Alvos[3, 3] = "D4";
            Alvos[3, 4] = "D5";
            Alvos[3, 5] = "D6";
            Alvos[3, 6] = "D7";
            Alvos[3, 7] = "D8";
            Alvos[3, 8] = "D9";
            Alvos[3, 9] = "D10";
            Alvos[4, 0] = "E1";
            Alvos[4, 1] = "E2";
            Alvos[4, 2] = "E3";
            Alvos[4, 3] = "E4";
            Alvos[4, 4] = "E5";
            Alvos[4, 5] = "E6";
            Alvos[4, 6] = "E7";
            Alvos[4, 7] = "E8";
            Alvos[4, 8] = "E9";
            Alvos[4, 9] = "E10";
            Alvos[5, 0] = "F1";
            Alvos[5, 1] = "F2";
            Alvos[5, 2] = "F3";
            Alvos[5, 3] = "F4";
            Alvos[5, 4] = "F5";
            Alvos[5, 5] = "F6";
            Alvos[5, 6] = "F7";
            Alvos[5, 7] = "F8";
            Alvos[5, 8] = "F9";
            Alvos[5, 9] = "F10";
            Alvos[6, 0] = "G1";
            Alvos[6, 1] = "G2";
            Alvos[6, 2] = "G3";
            Alvos[6, 3] = "G4";
            Alvos[6, 4] = "G5";
            Alvos[6, 5] = "G6";
            Alvos[6, 6] = "G7";
            Alvos[6, 7] = "G8";
            Alvos[6, 8] = "G9";
            Alvos[6, 9] = "G10";
            Alvos[7, 0] = "H1";
            Alvos[7, 1] = "H2";
            Alvos[7, 2] = "H3";
            Alvos[7, 3] = "H4";
            Alvos[7, 4] = "H5";
            Alvos[7, 5] = "H6";
            Alvos[7, 6] = "H7";
            Alvos[7, 7] = "H8";
            Alvos[7, 8] = "H9";
            Alvos[7, 9] = "H10";
            Alvos[8, 0] = "I1";
            Alvos[8, 1] = "I2";
            Alvos[8, 2] = "I3";
            Alvos[8, 3] = "I4";
            Alvos[8, 4] = "I5";
            Alvos[8, 5] = "I6";
            Alvos[8, 6] = "I7";
            Alvos[8, 7] = "I8";
            Alvos[8, 8] = "I9";
            Alvos[8, 9] = "I10";
            Alvos[9, 0] = "J1";
            Alvos[9, 1] = "J2";
            Alvos[9, 2] = "J3";
            Alvos[9, 3] = "J4";
            Alvos[9, 4] = "J5";
            Alvos[9, 5] = "J6";
            Alvos[9, 6] = "J7";
            Alvos[9, 7] = "J8";
            Alvos[9, 8] = "J9";
            Alvos[9, 9] = "J10";
            #endregion
            string escolha;
            #region primeira tabela com primeiras informações
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  " + 1+ "\t " + 2 + "\t " + 3 + "\t " + 4 + "\t " + 5 + "\t " + 6 + "\t " + 7 + "\t " + 8 + "\t " + 9 + "\t " + 10);
            Console.WriteLine("");
            Console.Write("A ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Alvos[0, 0] + "\t " + Alvos[0, 1] + "\t " + Alvos[0, 2] + "\t " + Alvos[0, 3] + "\t " + Alvos[0, 4] + "\t " + Alvos[0, 5] + "\t " + Alvos[0, 6] + "\t " + Alvos[0, 7] + "\t " + Alvos[0, 8] + "\t " + Alvos[0, 9]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("B ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Alvos[1, 0] + "\t " + Alvos[1, 1] + "\t " + Alvos[1, 2] + "\t " + Alvos[1, 3] + "\t " + Alvos[1, 4] + "\t " + Alvos[1, 5] + "\t " + Alvos[1, 6] + "\t " + Alvos[1, 7] + "\t " + Alvos[1, 8] + "\t " + Alvos[1, 9]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("C ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Alvos[2, 0] + "\t " + Alvos[2, 1] + "\t " + Alvos[2, 2] + "\t " + Alvos[2, 3] + "\t " + Alvos[2, 4] + "\t " + Alvos[2, 5] + "\t " + Alvos[2, 6] + "\t " + Alvos[2, 7] + "\t " + Alvos[2, 8] + "\t " + Alvos[2, 9]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("D ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Alvos[3, 0] + "\t " + Alvos[3, 1] + "\t " + Alvos[3, 2] + "\t " + Alvos[3, 3] + "\t " + Alvos[3, 4] + "\t " + Alvos[3, 5] + "\t " + Alvos[3, 6] + "\t " + Alvos[3, 7] + "\t " + Alvos[3, 8] + "\t " + Alvos[3, 9]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("E ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Alvos[4, 0] + "\t " + Alvos[4, 1] + "\t " + Alvos[4, 2] + "\t " + Alvos[4, 3] + "\t " + Alvos[4, 4] + "\t " + Alvos[4, 5] + "\t " + Alvos[4, 6] + "\t " + Alvos[4, 7] + "\t " + Alvos[4, 8] + "\t " + Alvos[4, 9]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("F ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Alvos[5, 0] + "\t " + Alvos[5, 1] + "\t " + Alvos[5, 2] + "\t " + Alvos[5, 3] + "\t " + Alvos[5, 4] + "\t " + Alvos[5, 5] + "\t " + Alvos[5, 6] + "\t " + Alvos[5, 7] + "\t " + Alvos[5, 8] + "\t " + Alvos[5, 9]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("G ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Alvos[6, 0] + "\t " + Alvos[6, 1] + "\t " + Alvos[6, 2] + "\t " + Alvos[6, 3] + "\t " + Alvos[6, 4] + "\t " + Alvos[6, 5] + "\t " + Alvos[6, 6] + "\t " + Alvos[6, 7] + "\t " + Alvos[6, 8] + "\t " + Alvos[6, 9]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("H ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Alvos[7, 0] + "\t " + Alvos[7, 1] + "\t " + Alvos[7, 2] + "\t " + Alvos[7, 3] + "\t " + Alvos[7, 4] + "\t " + Alvos[7, 5] + "\t " + Alvos[7, 6] + "\t " + Alvos[7, 7] + "\t " + Alvos[7, 8] + "\t " + Alvos[7, 9]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("I ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Alvos[8, 0] + "\t " + Alvos[8, 1] + "\t " + Alvos[8, 2] + "\t " + Alvos[8, 3] + "\t " + Alvos[8, 4] + "\t " + Alvos[8, 5] + "\t " + Alvos[8, 6] + "\t " + Alvos[8, 7] + "\t " + Alvos[8, 8] + "\t " + Alvos[8, 9]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("J ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Alvos[9, 0] + "\t " + Alvos[9, 1] + "\t " + Alvos[9, 2] + "\t " + Alvos[9, 3] + "\t " + Alvos[9, 4] + "\t " + Alvos[9, 5] + "\t " + Alvos[9, 6] + "\t " + Alvos[9, 7] + "\t " + Alvos[9, 8] + "\t " + Alvos[9, 9]);
            Console.WriteLine("");
            Console.WriteLine("Hidroavião = 1 casa");
            Console.WriteLine("Submarinos = 2 casas");
            Console.WriteLine("Cruzadores = 3 casas");
            Console.WriteLine("Encoraçados = 4 casas");
            Console.WriteLine("Porta-Avião = 5 casas");
            Console.WriteLine("");
            Console.WriteLine("Voce tem {0} tiros", tiro);
            #endregion
            #region Jogo
            for (int i = 0; i <= 2; i++)
            {
                #region Escolha do Jogador
                Console.WriteLine("");
                Console.WriteLine("Escolha um local");
                escolha = Console.ReadLine();
                #endregion
                #region Verifica Escolha e atribui a escolha
                for (int t = 0; t <= 9; t++)
                {
                    for (int p = 0; p <= 9; p++)
                    {
                        if (escolha == Alvos[t, p])
                        {
                            if (AlvosBack[t, p] == "H")
                            {
                                i = -1;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Acertou um Hidro Avião");
                                Console.ReadKey();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Alvos[t, p] = "H";
                                tiro = 3;
                            }
                            else
                            {
                                if (AlvosBack[t, p] == "S")
                                {
                                    
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Acertou um Submarino");
                                    Console.ReadKey();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Alvos[t, p] = "S";
                                    i =-1;
                                    tiro = 3;
                                }
                                else
                                {
                                    if (AlvosBack[t, p] == "C")
                                    {
                                        
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Acertou um Cruzador");
                                        Console.ReadKey();
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Alvos[t, p] = "C";
                                        i = -1;
                                        tiro = 3;
                                    }
                                    else
                                    {
                                        if (AlvosBack[t, p] == "E")
                                        {
                                            
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Acertou um Encoraçados");
                                            Console.ReadKey();
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Alvos[t, p] = "E";
                                            i = -1;
                                            tiro = 3;
                                        }
                                        else
                                        {
                                            if (AlvosBack[t, p] == "P")
                                            {
                                                
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Acertou um Porta-Avião");
                                                Console.ReadKey();
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                Alvos[t, p] = "P";
                                                i = -1;
                                                tiro = 3;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("Caiu agua");
                                                Console.ReadKey();
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                Alvos[t, p] = "A";
                                                tiro = tiro - 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }  
                    }
                }
                #endregion
                #region Possibilidades de Vitorias
                if (Alvos[0, 2] == "H" && Alvos[0, 7] == "H" && Alvos[3, 8] == "H" && Alvos[5, 1] == "H" && Alvos[7, 0] == "H" && Alvos[0, 9] == "S" && Alvos[1, 9] == "S" && Alvos[3, 3] == "S" && Alvos[3, 4] == "S" && Alvos[5, 3] == "S" && Alvos[6, 3] == "S" && Alvos[9, 1] == "S" && Alvos[9, 2] == "S" && Alvos[8, 4] == "C" && Alvos[9, 4] == "C" && Alvos[9, 5] == "C" && Alvos[8, 8] == "C" && Alvos[9, 8] == "C" && Alvos[9, 7] == "C" && Alvos[1, 0] == "C" && Alvos[2, 0] == "C" && Alvos[2, 1] == "C" && Alvos[0, 4] == "E" && Alvos[0, 5] == "E" && Alvos[1, 4] == "E" && Alvos[1, 5] == "E" && Alvos[5, 8] == "E" && Alvos[5, 9] == "E" && Alvos[6, 8] == "E" && Alvos[6, 9] == "E" && Alvos[3, 6] == "P" && Alvos[4, 6] == "P" && Alvos[5, 6] == "P" && Alvos[6, 6] == "P" && Alvos[7, 6] == "P")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Voce acertou todas as armas do inimigo! VITORIA");
                    Console.ReadKey();
                    return;
                }
                #endregion
                #region Mostrar Tabela Atualizada
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("  " + 1 + "\t " + 2 + "\t " + 3 + "\t " + 4 + "\t " + 5 + "\t " + 6 + "\t " + 7 + "\t " + 8 + "\t " + 9 + "\t " + 10);
                Console.WriteLine("");
                Console.Write("A ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Alvos[0, 0] + "\t " + Alvos[0, 1] + "\t " + Alvos[0, 2] + "\t " + Alvos[0, 3] + "\t " + Alvos[0, 4] + "\t " + Alvos[0, 5] + "\t " + Alvos[0, 6] + "\t " + Alvos[0, 7] + "\t " + Alvos[0, 8] + "\t " + Alvos[0, 9]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("B ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Alvos[1, 0] + "\t " + Alvos[1, 1] + "\t " + Alvos[1, 2] + "\t " + Alvos[1, 3] + "\t " + Alvos[1, 4] + "\t " + Alvos[1, 5] + "\t " + Alvos[1, 6] + "\t " + Alvos[1, 7] + "\t " + Alvos[1, 8] + "\t " + Alvos[1, 9]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("C ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Alvos[2, 0] + "\t " + Alvos[2, 1] + "\t " + Alvos[2, 2] + "\t " + Alvos[2, 3] + "\t " + Alvos[2, 4] + "\t " + Alvos[2, 5] + "\t " + Alvos[2, 6] + "\t " + Alvos[2, 7] + "\t " + Alvos[2, 8] + "\t " + Alvos[2, 9]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("D ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Alvos[3, 0] + "\t " + Alvos[3, 1] + "\t " + Alvos[3, 2] + "\t " + Alvos[3, 3] + "\t " + Alvos[3, 4] + "\t " + Alvos[3, 5] + "\t " + Alvos[3, 6] + "\t " + Alvos[3, 7] + "\t " + Alvos[3, 8] + "\t " + Alvos[3, 9]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("E ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Alvos[4, 0] + "\t " + Alvos[4, 1] + "\t " + Alvos[4, 2] + "\t " + Alvos[4, 3] + "\t " + Alvos[4, 4] + "\t " + Alvos[4, 5] + "\t " + Alvos[4, 6] + "\t " + Alvos[4, 7] + "\t " + Alvos[4, 8] + "\t " + Alvos[4, 9]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("F ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Alvos[5, 0] + "\t " + Alvos[5, 1] + "\t " + Alvos[5, 2] + "\t " + Alvos[5, 3] + "\t " + Alvos[5, 4] + "\t " + Alvos[5, 5] + "\t " + Alvos[5, 6] + "\t " + Alvos[5, 7] + "\t " + Alvos[5, 8] + "\t " + Alvos[5, 9]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("G ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Alvos[6, 0] + "\t " + Alvos[6, 1] + "\t " + Alvos[6, 2] + "\t " + Alvos[6, 3] + "\t " + Alvos[6, 4] + "\t " + Alvos[6, 5] + "\t " + Alvos[6, 6] + "\t " + Alvos[6, 7] + "\t " + Alvos[6, 8] + "\t " + Alvos[6, 9]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("H ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Alvos[7, 0] + "\t " + Alvos[7, 1] + "\t " + Alvos[7, 2] + "\t " + Alvos[7, 3] + "\t " + Alvos[7, 4] + "\t " + Alvos[7, 5] + "\t " + Alvos[7, 6] + "\t " + Alvos[7, 7] + "\t " + Alvos[7, 8] + "\t " + Alvos[7, 9]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("I ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Alvos[8, 0] + "\t " + Alvos[8, 1] + "\t " + Alvos[8, 2] + "\t " + Alvos[8, 3] + "\t " + Alvos[8, 4] + "\t " + Alvos[8, 5] + "\t " + Alvos[8, 6] + "\t " + Alvos[8, 7] + "\t " + Alvos[8, 8] + "\t " + Alvos[8, 9]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("J ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Alvos[9, 0] + "\t " + Alvos[9, 1] + "\t " + Alvos[9, 2] + "\t " + Alvos[9, 3] + "\t " + Alvos[9, 4] + "\t " + Alvos[9, 5] + "\t " + Alvos[9, 6] + "\t " + Alvos[9, 7] + "\t " + Alvos[9, 8] + "\t " + Alvos[9, 9]);
                #endregion
                #region Informações
                Console.WriteLine("");
                Console.WriteLine("Hidroavião = 1 casa");
                Console.WriteLine("Submarinos = 2 casas");
                Console.WriteLine("Cruzadores = 3 casas");
                Console.WriteLine("Encoraçados = 4 casas");
                Console.WriteLine("Porta-Avião = 5 casas");
                Console.WriteLine("");
                Console.WriteLine("Voce tem {0} tiros", tiro);
                #endregion
            }
            #endregion
            #region Derrota
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Voce perdeu suas chances! DERROTA");
            Console.ReadKey();
            return;
            #endregion
        }
    }
}
