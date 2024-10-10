using InsertSort; //Observação ''(aspa símples) é utilizada para somente 1 caracter, já as ""(aspas duplas) para mais de 1 caracter!

int[] inteiros = {0, 12, 7, 1, 2, 8};

InsertSort.InsertSort.Print(inteiros);

InsertSort.InsertSort.Sort<int>(inteiros);

InsertSort.InsertSort.Print(inteiros); // Como fizemos a declaração na Class InsertSort, só será necessário trazer a declaração para o programa e show!

Console.WriteLine("Teste Char");

char[] chars = ['x', 'z', 'b', 'c', 'a'];
InsertSort.InsertSort.Print(chars);
InsertSort.InsertSort.Sort(chars);
InsertSort.InsertSort.Print(chars);