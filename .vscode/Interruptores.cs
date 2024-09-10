using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interruptores
{
   class Program
    {
        static void Main(string[] args)
        {
           
            string[] lampadas = { "Lâmpada 1", "Lâmpada 2", "Lâmpada 3" };
            bool[] estadoLampadas = { false, false, false }; 
         
            bool[] interruptores = { false, false, false }; 
       
            Console.WriteLine("Ligue o Interruptor 1 e aguarde 10 minutos...");
            interruptores[0] = true; 
            SimularEspera(10);

            Console.WriteLine("Desligue o Interruptor 1 e ligue o Interruptor 2...");
            interruptores[0] = false; 
            interruptores[1] = true;  
        
            estadoLampadas[0] = true; 
            estadoLampadas[1] = true; 

            Console.WriteLine("Estado das lâmpadas após verificar:");

            for (int i = 0; i < lampadas.Length; i++)
            {
                string estado = estadoLampadas[i] ? "acesa" : "apagada";
                Console.WriteLine($"{lampadas[i]} está {estado}.");
            }

            Console.WriteLine("\nIdentificação dos interruptores:");
            Console.WriteLine("Lâmpada acesa e quente: Conectada ao Interruptor 1");
            Console.WriteLine("Lâmpada acesa e fria: Conectada ao Interruptor 2");
            Console.WriteLine("Lâmpada apagada e quente: Conectada ao Interruptor 3");
        }

        static void SimularEspera(int minutos)
        {
            Console.WriteLine($"Esperando {minutos} minutos...");
        }
    }
}