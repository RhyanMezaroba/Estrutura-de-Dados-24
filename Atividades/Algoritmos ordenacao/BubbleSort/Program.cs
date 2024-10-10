using BubbleSort; //Observação ''(aspa símples) é utilizada para somente 1 caracter, já as ""(aspas duplas) para mais de 1 caracter!

int[] inteiros = {0, 12, 7, 1, 2, 8};

BubbleSort.BubbleSort.Print(inteiros);

BubbleSort.BubbleSort.Sort<int>(inteiros);

BubbleSort.BubbleSort.Print(inteiros); // Como fizemos a declaração na Class BubbleSort, só será necessário trazer a declaração para o programa e show!

Console.WriteLine("Teste Char");

char[] chars = ['x', 'z', 'b', 'c', 'a'];
BubbleSort.BubbleSort.Print(chars);
BubbleSort.BubbleSort.Sort(chars);
BubbleSort.BubbleSort.Print(chars);