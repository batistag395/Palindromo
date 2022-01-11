using System;

namespace Plalindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            String palavra, inverso, caracter;
            int i;
            Console.WriteLine("Qual palavra deseja verificar? :");
            palavra = Convert.ToString(Console.ReadLine());
            i = palavra.Length;
            inverso = "";
            for (int x = i - 1; x >= 0; x--)
            {
                caracter = palavra.Substring(x, 1);
                inverso += caracter;
            }


            if (palavra == inverso)
            {
                Console.WriteLine("A palavra é um palindromo", Console.ForegroundColor=ConsoleColor.Green);

            }

            else
            {
                Console.WriteLine("A palavra não é um palindromo", Console.ForegroundColor = ConsoleColor.Red);

            }
            Console.ReadKey();

        }
    }
}
