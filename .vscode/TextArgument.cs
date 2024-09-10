using System;

namespace TextArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe uma string: ");
            string text = Console.ReadLine();

            (int minusculas, int maiusculas) = CalcOcorrenciasDeA(text);

            
            int tot = minusculas + maiusculas;

            Console.WriteLine($"A letra 'a' minúscula ocorre {minusculas} vez(es).");
            Console.WriteLine($"A letra 'A' maiúscula ocorre {maiusculas} vez(es).");
            Console.WriteLine($"No total, a letra 'a' (maiúscula ou minúscula) ocorre {tot} vez(es) na string.");
        }

        static (int, int) CalcOcorrenciasDeA(string text)
        {
            int contMinusculas = 0;
            int contMaiusculas = 0;
    
            foreach (char t in text)
            {
                if (t == 'a')
                {
                    contMinusculas++;
                }
                else if (t == 'A')
                {
                    contMaiusculas++;
                }
            }

            return (contMinusculas, contMaiusculas);
        }
    }   
}