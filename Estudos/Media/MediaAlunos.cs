using System;
class Media
{
    static void Main()
    {
        Console.WriteLine("!Notas dos Alunos!");

        Console.Write("Digite a primeira nota:");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota:");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota:");
        double nota3 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3)/3;

        Console.WriteLine("Média de notas: " + media);

        if(media >= 6.00)
        {
            Console.WriteLine("Aluno Aprovado!");
        }

        else
        {
            Console.WriteLine("Aluno Repovado!");            
        }

    }

}