//String

using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite um número entre 1 e 100: ");
        string entrada = Console.ReadLine();

        int numero;
        bool sucesso = int.TryParse(entrada, out numero);

        if(sucesso && numero >=1 && numero <= 100)
        {
            string conclusao = "Fez o mínimo kkkkk";
            Console.WriteLine(conclusao);
        }
        else
        {
            string ops = "Muleque burro kkkkk";
            Console.WriteLine(ops);
        }
    }

}