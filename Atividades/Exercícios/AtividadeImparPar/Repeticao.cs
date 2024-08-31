using System;

class Program
{
    static void Main()
    {
        ContaNumero();
    }

    static void ContaNumero()
    {
        Console.WriteLine("Números Pares:");
        for(int i = 0; i <= 100; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Números Ímpares:");
        for(int i = 0; i <= 100; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
