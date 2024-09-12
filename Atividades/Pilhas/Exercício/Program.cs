Console.WriteLine("Vamos testar se a sua palavra É ou NÃO um PALÍNDROMO!!!");
Stack<char> stack = new Stack<char>();
    Console.WriteLine("");
    Console.Write("Escreva uma palavra:");
        string palavra = Console.ReadLine();

    foreach (char c in palavra)
    {
        stack.Push (c);
    }
