using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2073
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            Console.Write("\n O ano é 2073.\n\n Você é o filho do dono de uma empresa que foi principal desenvolvedor da 1º\n máquina do tempo feita na história.\n\n Um grupo extremo se tornou interessado em colocar as mãos na mesma: \n os Ampulhetas.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("\n É marcada uma data para a primeira demostração da máquina do tempo.\n \n Seu pai planeja fazer a primeira viagem. \n \n Você: \n \n 1- Incentiva-o a continuar com a ideia de viajar no tempo. \n \n 2- Diz que sente medo de que algo ruim aconteça, então pede para ele não ir. \n");
            do
            {
                try
                {
                    Console.Write("\n ");
                    escolha = int.Parse(Console.ReadLine());
                }
                catch
                {
                    escolha = 0;
                }
                Console.WriteLine("Insira somente 1 ou 2 \n");
            }
            while (escolha != 1 && escolha != 2);
            Console.Clear();
            switch(escolha)
            {
                case 1:
                    {
                        Console.Write("\n Seu pai agradece o incentivo. Logo chega o grande dia. \n \n Um grupo pequeno de pessoas se encontra numa sala do laboratorio \n para ver o funcionamento da máquina. De repente, uma parede explode e dela \n saem um grupo de Ampulhetas, que começam a atirar Seu pai, que está próximo\n à máquina, é atingido e morre. Você é acertado logo em seguida, ao tentar\n correr em direção à ele. MORREU");
                        Console.ReadKey();
                        return;
                    }
                case 2:
                    {
                        Console.Write("\n Seu pai aceita e diz que não irá. \n \n O grande dia chega. Você e um grupo de pessoas se encontra numa sala no\n laboratório para demostração da máquina. \n \n De repente, a parede explode e um grupo de Ampulhetas aparece e começa um\n tiroteio. Seu pai está ao seu lado. \n \n Você: \n \n 1- Pensa em alguma maneira de impedir os Ampulhetas de roubarem o\n trabalho de seu pai. \n \n 2- Segura seu pai e corre em direção à saída do laboratório. \n");
                        break;
                    }
            }

            do
            {
                try
                {
                    Console.Write("\n ");
                    escolha = int.Parse(Console.ReadLine());
                }
                catch
                {
                    escolha = 0;
                }
                Console.WriteLine("Insira somente 1 ou 2 \n");
            }
            while (escolha != 1 && escolha != 2);

            Console.Clear();
            switch(escolha)
            {
                case 1:
                    {
                        Console.Write("\n Antes que você possa completar seus pensamentos, você sente uma mão te\n puxando para outro corredor do laboratório. \n \n A pessoa que te puxou vira e diz para você não se preocupar. \n \n Ela faz parte de uma organização criada secretamente pelo seu pai para\n proteger a máquina. \n \n Seu nome é Charlie. \n \n Ele diz que a organização ja resgatou seu pai. \n Ele ainda diz que devem impedir os Ampulhetas. Vocês voltam para a\n sala da máquina. \n \n Você: \n \n 1- Sugere atirar na máquina e destruí-la. Assim, os Ampulhetas não\n colocariam as mãos nela. \n \n 2- Tenta atirar nos Ampulhetas. \n \n 3- Desiste e os deixa pegar a máquina. \n");
                        break;
                    }
                case 2:
                    {
                        Console.Write("\n Você e seu pai correm em direção à saída, mas dão de cara com mais\n ampulhetas e morrem na hora. \n \n MORREU.");
                        Console.ReadKey();
                        return;
                    }
            }
            escolha = 0;
            do
            {
                try
                {
                    Console.Write("\n ");
                    escolha = int.Parse(Console.ReadLine());
                }
                catch
                {
                    escolha = 0;
                }
                Console.WriteLine("Insira somente 1 a 3 \n");
            }
            while (escolha != 1 && escolha != 2 && escolha != 3);

            Console.Clear();
            switch(escolha)
            {
                case 1:
                    {
                        Console.Write("\n Charlie diz não ser uma boa ideia, mas você não escuta. \n \n Você, sabendo os pontos sensíveis da máquina. \n \n Pega uma arma no chão e atira. \n \n A máquina é destruída. Os Ampulhetas fogem. Seu pai aparece bem ao seu lado\n e Charlie desapareceu. \n \n Você esquece dele, pois ele foi apagado da existência. \n \n Você é reconhecido como herói.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n Este foi um dos finais bons. Para melhor entendimento da história,\n jogue novamente e tente novas escolhas.");
                        break;
                    }
                case 2:
                    {
                        Console.Write("\n Você e Charlie conseguem atrasar os Ampulhetas atirando neles, o suficiente\n para os militares chegarem, e prenderem os Ampulhetas. \n \n Você agradece Charlie e ele vai embora.\n O pessoal do governo chega e fala que, para melhor proteção de você e seu pai,\n já que muitos Ampulhetas ainda estavam à solta, \n seria necessário ambos mudarem de identidade. dentre as sugestões de nome para\n você: 'Charlie'.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n Este foi o melhor final. Experimente jogar novamente e tente novas escolhas.");
                        break;
                    }
                case 3:
                    {
                        Console.Write("\n Os Ampulhetas pegam a máquina e, com ela, escravizam o mundo.\n \n Você e seu pai são mortos.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n Este foi o final ruim. Tente jogar novamente e faça novas escolhas.");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
