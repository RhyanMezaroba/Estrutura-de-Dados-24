using System;
class Program
{    
    static void Main()
    {
        ContarNumeros();
    }

    static void ContarNumeros()
    {
        // Variáveis para armazenar números pares e ímpares
        Console.WriteLine("Números Pares:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) // Verifica se o número é par
            {
                Console.WriteLine(i);
            }
        }
        
        Console.WriteLine("Números Ímpares:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0) // Verifica se o número é ímpar
            {
                Console.WriteLine(i);
            }
        }
    }
}
