using System;

namespace SomIndice
{
    class Program
    {
        static void Main(string[] args)
        {
            int ind = 12, soma = 0, k = 1;

            while (k < ind)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine("O valor final de SOMA é: " + soma);
        }
    }   
}