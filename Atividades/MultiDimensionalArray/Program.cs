// Criando um vetor multidimensional com 5 linhas e 2 colunas!
int[,] numbers = new int[5,2];

// Criando um vetor tridimensional
int [,,] triNumbers = new int[5,4,3];

//Podemos inicializar os valores do vetor no momento da sua declaração
int[,] iniNumbers = new int[,]
{
    {9,5,0,}, // linha declarada abaixo
    {93,2,-100,},
    {43,4,-99,},
    {95,18,-30,},
    {8,22,-1,},
};

//Para acessar os valores contidos neste tipo de variável
int valor = iniNumbers[0,1]; // neste caso = 5

Console.WriteLine($"iniNumbers[0,1] = {valor}");