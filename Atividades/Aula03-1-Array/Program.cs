// Array Unidimensional
int[] numbers;
numbers = new int[5];

//Atribuição de valor direta ao índice do Vetor
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

// Declaração inicializada 
string[] names =
    {"Eu", "Tu", "Ele","Nós", "Vós", "Eles"};

// Exemplo Vetor com os nomes dos meses
string[] months = new string[12];
for(int i = 1; i <= 12; i++)
{
    DateTime firstDay =
        new DateTime(
            DateTime.Now.Year, i, 1);
string name = 
    firstDay.ToString("MMMM"); //Fromato MMMM (Mes por extenso)

    months[i-1] = name; // [i-1] => Guarda para as casas na matriz
}

foreach(string m in months)
{
        Console.WriteLine(m);
}