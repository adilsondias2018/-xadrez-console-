using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(2, 3);

            Console.WriteLine("Posição:" + P);

            Console.ReadLine();


        }
    }
}
