using System;

namespace Aula_de_PC1_DIV_
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerador;
            double denominador;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Vamos fazer uma divisão simples!");
            Console.WriteLine("--------------------------------");
            Console.ResetColor();

            Console.WriteLine("Digite o valor do numerador:");
            Console.ForegroundColor = ConsoleColor.Green;
            numerador = double.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Agora digite o valor do denominador:");
            denominador = double.Parse(Console.ReadLine());
            double quociente = numerador / denominador;
            
            if (denominador > 0 )
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{numerador} dividido por {denominador} é igual a: {quociente}");
                Console.ResetColor();
                Console.WriteLine("\nObrigada! Tecle ENTER para sair:");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
               Console.ForegroundColor = ConsoleColor.DarkRed;
               Console.WriteLine("O DENOMINADOR DEVE SER MAIOR QUE ZERO.");
               Console.ResetColor();
               Console.WriteLine("Pressione qualquer botão para fechar o programa.");
               Console.ReadKey();
               Console.Clear();
            }

        }
    }
}
