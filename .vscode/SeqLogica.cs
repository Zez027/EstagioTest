using System;

namespace SeqLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seqA = { 1, 3, 5, 7 };
            int proxA = seqA[seqA.Length - 1] + 2;
            Console.WriteLine($"Próximo número da sequência A: {proxA}");

            
            int[] seqB = { 2, 4, 8, 16, 32, 64 };
            int proxB = seqB[seqB.Length - 1] * 2;
            Console.WriteLine($"Próximo número da sequência B: {proxB}");

            
            int[] seqC = { 0, 1, 4, 9, 16, 25, 36 };
            int proxC = (int)Math.Pow(seqC.Length, 2);
            Console.WriteLine($"Próximo número da sequência C: {proxC}");

            
            int[] seqD = { 4, 16, 36, 64 };
            int proxD = (int)Math.Pow((seqD.Length + 1) * 2, 2);
            Console.WriteLine($"Próximo número da sequência D: {proxD}");

            
            int[] seqE = { 1, 1, 2, 3, 5, 8 };
            int proxE = seqE[seqE.Length - 1] + seqE[seqE.Length - 2];
            Console.WriteLine($"Próximo número da sequência E: {proxE}");

            
            int[] seqF = { 2, 10, 12, 16, 17, 18, 19 };
            int proxF = seqF[seqF.Length - 1] + 1;
            Console.WriteLine($"Próximo número da sequência F: {proxF}");
        }
    }
}