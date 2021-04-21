using System;

namespace Aula_de_PC1_DIV_
{
    class Program
    {
        static void Main(string[] args)
        {
            double Numerador, Denominador;
            double Quociente = Numerador / Denominador;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Vamos fazer uma divisão simples!");
            Console.WriteLine("--------------------------------");
            Console.ResetColor();

            Console.WriteLine("Digite o valor do numerador:");
            Console.ForegroundColor = ConsoleColor.Green;
            Numerador = Convert.ToInt16(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Agora digite o valor do denominador:");
            Denominador = Convert.ToInt32(Console.ReadLine());

            if(Denominador > 0)
            {
    
                Console.WriteLine($"{Numerador} dividio por {Denominador} é igual a {Quociente}");
            }

            else
            {
                Console.WriteLine($"O número {Numerador} não pode ser dividido por 0 (Zero).\nReinicie o programa!\n\nTecle Enter para sair.");
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
