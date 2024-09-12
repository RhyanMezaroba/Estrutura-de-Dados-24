List<string> livros = new List<string>();
{
Console.WriteLine("Listagem de Livros!");

    for(int i = 0; i < 5; i++)  
    {
        Console.Write("Nome do Livro: ");
            string? Name = Console.ReadLine();
        Console.Write("Editora: ");
            string? Editora = Console.ReadLine();
        Console.Write("Autor(es): ");
            string? Autor = Console.ReadLine();
        Console.Write("Número de Páginas: ");
            int Pages = int.Parse(Console.ReadLine());
    }
}