using System.ComponentModel;
using System;
using System.Collections.Generic;

class Livro{
    public required string Nome {get; set;}
    public required string Editora {get; set;}
    public required string Autor {get; set;}
    public int NumeroPaginas {get; set;}
}
class Program
{
    static void Main(string[] args)
    {
        List<Livro> livros = new List<Livro>();
            Console.Write("Quantos Livros você deseja cadastrar: ");
                int QuantidadeLivros = int.Parse(Console.ReadLine());

        for(int i = 0; i < QuantidadeLivros; i++)
        {
            Console.WriteLine($"\nDigite os dados do {i+1}º Livro");
            Livro livro = new Livro
            {
                Nome = Console.ReadLine(),
                Editora = Console.ReadLine(),
                Autor = Console.ReadLine(),
                NumeroPaginas = int.Parse(Console.ReadLine()),            
            };
            livros.Add(livro);
        }

    Livro livroMaiorPaginas = livros[0];
        foreach(var livro in livros)
        {
            if (livro.NumeroPaginas > livroMaiorPaginas.NumeroPaginas)
            {
                livroMaiorPaginas = livro;
            }
        }
    Console.WriteLine("\nLivro com o maior número de páginas:");
    Console.WriteLine($"Nome: {livroMaiorPaginas.Nome}");
    Console.WriteLine($"Editora: {livroMaiorPaginas.Editora}");
    Console.WriteLine($"Autor: {livroMaiorPaginas.Autor}");
    Console.WriteLine($"Número de páginas: {livroMaiorPaginas.NumeroPaginas}");
    }
}