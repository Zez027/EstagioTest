using System;

namespace SeqFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());

            bool pertence = FibonacciCalc(num);

            if (pertence)
            {
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {num} NÃO pertence à sequência de Fibonacci.");
            }
        }

        static bool FibonacciCalc(int num)
        {
            int ant = 0;
            int atual = 1;

            if (num == 0)
                return true;

            while (atual <= num)
            {
                if (atual == num)
                    return true;

                int prox = ant + atual;
                ant = atual;
                atual = prox;
            }
            return false;
        }
    }
}