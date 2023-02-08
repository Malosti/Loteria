using System;
using System.Threading;

namespace Loteria
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
            
        }

        public static void Menu()
        {
            Console.WriteLine("Bem vindo a Loterias Malosti Fonseca");
            Console.WriteLine(@"====================================");
            Console.WriteLine(@"\°/\°/\°/\°/\°/\°/\°/\°/\°/\°/\°/\°/");
            Console.WriteLine(@"====================================");
            Console.WriteLine("Escolha qual loteria deseja rodar: ");
            Console.WriteLine("[1] - MEGA - SENA");
            Console.WriteLine("[2] - DUPLA -SENA");
            Console.WriteLine("[3] - LOTOFACIL");
            Console.WriteLine("[4] - Sair");
            short escolha = Convert.ToInt16(Console.ReadLine());

            switch (escolha)
            {
                case 1: MegaSena(); break;
                case 2: DuplaSena(); break;
                case 3: LotoFacil(); break;
                case 4: Environment.Exit(0); break;
                default:
                    {
                        Console.Clear(); Menu(); break;
                    } 

            }
        }

        public static void MegaSena()
        {
            Cabecalho();
            Console.WriteLine(@"=========================");
            Console.WriteLine(@"\o/ Sorteio Mega Sena \o/");
            Console.WriteLine(@"=========================");
            Console.WriteLine("Estes são os numeros sorteados");


            Random aleatorioN = new Random();

            for(int i = 0; i < 6; i++)
            {
               Console.WriteLine($" Numero {i + 1} ... |{aleatorioN.Next(1,60),1:N0}|");
            }
            
        }

        public static void DuplaSena()
        {
            Cabecalho();
            Console.WriteLine(@"=========================");
            Console.WriteLine(@"\o/ Sorteio Dupla Sena \o/");
            Console.WriteLine(@"=========================");
            Console.WriteLine("Estes são os numeros sorteados");


            Random aleatorioN = new Random();

            Console.WriteLine("1° Sorteio");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($" Numero {i + 1} ... |{aleatorioN.Next(1, 60),1:N0}|");
            }
            Console.WriteLine("");
            Console.WriteLine("2° Sorteio");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($" Numero {i + 1} ... |{aleatorioN.Next(1, 60),1:N0}|");
            }
        }

        public static void LotoFacil()
        {
            Cabecalho();
            Console.WriteLine(@"=========================");
            Console.WriteLine(@"\o/ Sorteio Mega Sena \o/");
            Console.WriteLine(@"=========================");
            Console.WriteLine("Estes são os numeros sorteados");


            Random aleatorioN = new Random();
            int numSorteado;
            var verificador = new int[60];

            for (int i = 0; i < 15; i++)
            {
                Inicio:
                numSorteado = aleatorioN.Next(1, 60);

                for (int j = 0; j < 60; j++)
                {
                    if (verificador[j] == numSorteado)
                    {
                        goto Inicio;
                    }
                }
   
                Console.WriteLine($" Numero {i + 1} ...... |{numSorteado}|");
                verificador[i] = numSorteado;
            }
        }

        public static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine(@"=======================");
            Console.WriteLine("LOTERIAS MALOSTI FONSECA");
            Console.WriteLine(@"=======================");
            Console.WriteLine("\n");
            Console.WriteLine("Aguarde um instante, estamos sorteando os numeros...");
            Thread.Sleep(3000);
            Console.WriteLine("Pronto... Aperte uma tecla para conferir os numeros");
            Console.ReadKey();
            Console.Clear();
        }
    } 
}
