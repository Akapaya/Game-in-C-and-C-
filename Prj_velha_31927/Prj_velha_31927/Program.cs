using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prj_velha_31927
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] alvos = new string[3, 3];
            #region alvos
            alvos[0, 0] = "*";
            alvos[1, 0] = "*";
            alvos[2, 0] = "*";
            alvos[0, 1] = "*";
            alvos[1, 1] = "*";
            alvos[2, 1] = "*";
            alvos[0, 2] = "*";
            alvos[1, 2] = "*";
            alvos[2, 2] = "*";
            #endregion
            int p = 0;
            string escolha;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Escolha"+ p);
                escolha = Console.ReadLine();
                #region possibilidades
                if (escolha == "superior esquerdo" )
                {
                    switch(p)
                    {
                        case 0:
                            {
                                alvos[0, 0] = "x";
                                break;
                            }
                        case 1:
                            {
                                alvos[0, 0] = "o";
                                break;
                            }
                    }    
                    
                }

                if (escolha == "superior")
                {
                    switch (p)
                    {
                        case 0:
                            {
                                alvos[0, 1] = "x";
                                break;
                            }
                        case 1:
                            {
                                alvos[0, 1] = "o";
                                break;
                            }
                    }
                }

                if (escolha == "superior direito")
                {
                    switch (p)
                    {
                        case 0:
                            {
                                alvos[0, 2] = "x";
                                break;
                            }
                        case 1:
                            {
                                alvos[0, 2] = "o";
                                break;
                            }
                    }
                }

                if (escolha == "centro esquerdo" )
                {
                    switch (p)
                    {
                        case 0:
                            {
                                alvos[1, 0] = "x";
                                break;
                            }
                        case 1:
                            {
                                alvos[1, 0] = "o";
                                break;
                            }
                    }
                }

                if (escolha == "centro")
                {
                    switch (p)
                    {
                        case 0:
                            {
                                alvos[1, 1] = "x";
                                break;
                            }
                        case 1:
                            {
                                alvos[1, 1] = "o";
                                break;
                            }
                    }
                }

                if (escolha == "centro direito")
                {
                    switch (p)
                    {
                        case 0:
                            {
                                alvos[1, 2] = "x";
                                break;
                            }
                        case 1:
                            {
                                alvos[1, 2] = "o";
                                break;
                            }
                    }
                }

                if (escolha == "inferior esquerdo")
                {
                    switch (p)
                    {
                        case 0:
                            {
                                alvos[2, 0] = "x";
                                break;
                            }
                        case 1:
                            {
                                alvos[2, 0] = "o";
                                break;
                            }
                    }
                }
                if (escolha == "inferior" )
                {
                    switch (p)
                    {
                        case 0:
                            {
                                alvos[2, 1] = "x";
                                break;
                            }
                        case 1:
                            {
                                alvos[2, 1] = "o";
                                break;
                            }
                    }
                }
                if (escolha == "inferior direito")
                {
                    switch (p)
                    {
                        case 0:
                            {
                                alvos[2, 2] = "x";
                                break;
                            }
                        case 1:
                            {
                                alvos[2, 2] = "o";
                                break;
                            }
                    }
                }
                #endregion
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
                #region possibilidades win
                if (alvos[0, 0] == "x" && alvos[0, 1] == "x" && alvos[0, 2] == "x"
                    || alvos[1, 0] == "x" && alvos[1, 1] == "x" && alvos[1, 2] == "x"
                    || alvos[2, 0] == "x" && alvos[2, 1] == "x" && alvos[2, 2] == "x"
                    || alvos[0, 0] == "x" && alvos[1, 1] == "x" && alvos[2, 2] == "x"
                    || alvos[2, 0] == "x" && alvos[1, 1] == "x" && alvos[0, 2] == "x"
                    || alvos[1, 0] == "x" && alvos[0, 0] == "x" && alvos[2, 0] == "x"
                    || alvos[1, 1] == "x" && alvos[0, 1] == "x" && alvos[2, 1] == "x"
                    || alvos[1, 2] == "x" && alvos[0, 2] == "x" && alvos[2, 2] == "x")
                {
                    Console.WriteLine("Player 1 ganhou");
                    Console.ReadKey();
                    return;
                }
                if (alvos[0, 0] == "o" && alvos[0, 1] == "o" && alvos[0, 2] == "o"
                    || alvos[1, 0] == "o" && alvos[1, 1] == "o" && alvos[1, 2] == "o"
                    || alvos[2, 0] == "o" && alvos[2, 1] == "o" && alvos[2, 2] == "o"
                    || alvos[0, 0] == "o" && alvos[1, 1] == "o" && alvos[2, 2] == "o"
                    || alvos[2, 0] == "o" && alvos[1, 1] == "o" && alvos[0, 2] == "o"
                    || alvos[1, 0] == "o" && alvos[0, 0] == "o" && alvos[2, 0] == "o"
                    || alvos[1, 1] == "o" && alvos[0, 1] == "o" && alvos[2, 1] == "o"
                    || alvos[1, 2] == "o" && alvos[0, 2] == "o" && alvos[2, 2] == "o")
                {
                    Console.WriteLine("Player 2 ganhou");
                    Console.ReadKey();
                    return;
                }
                #endregion
                Console.WriteLine(alvos[0, 0] + "\t" + alvos[0, 1] + "\t" + alvos[0, 2]);
                Console.WriteLine(alvos[1, 0] + "\t" + alvos[1, 1] + "\t" + alvos[1, 2]);
                Console.WriteLine(alvos[2, 0] + "\t" + alvos[2, 1] + "\t" + alvos[2, 2]);
            }
        }
    }
}
