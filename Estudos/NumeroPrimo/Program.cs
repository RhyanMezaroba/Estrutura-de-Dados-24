using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro para saber se é primo:");
        int number = int.Parse(Console.ReadLine());

        int i;
        bool primo = true;

        if(number <= 1)
        {
            primo = false;
        }
        
        else
        {
            for(i = 2; i <= Math.Sqrt(number); i++);
            {
                if(number % i == 0)
                {
                    primo = false;
                }
            }
        
        }

        if(primo)
        {
            Console.WriteLine(number + " é um número primo");
        }

        else
        {
            Console.WriteLine(number + " não é um número primo");
        }

    }

}