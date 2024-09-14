Console.WriteLine("Vamos criar uma PILHA e descobrir se a sua palavra é um PALÍNDROMO!!!");
Console.Write("\nDigite uma palavra: ");
   string? palavra = Console.ReadLine();

Stack<char> caracteres = new Stack<char> ();
    foreach (char c in palavra)
    {
        caracteres.Push (c);
    }

string invertido = string.Empty;
    while(caracteres.Count > 0)
    {
        invertido += caracteres.Pop ();
    }

Console.Write("\nSua palavra invertida: ");
Console.WriteLine (invertido);