int [,] number = new int[5,2];

int[,] iniNumbers = new int[,]
{
    {9,5,0,},
    {3,2,-100,},
    {43,4,-99,},
    {95,18,-30,},
    {8,22,-1,},
};
int MaiorValor = iniNumbers[0,0];
int LinhaMaior = 0;
int ColunaMaior = 0;

    for (int i = 0; i < iniNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < iniNumbers.GetLength(1); j++)
        {
            if (iniNumbers[i,j] > MaiorValor)
            { 
                MaiorValor = iniNumbers[i, j];
                LinhaMaior = i;
                ColunaMaior = j;
            }
        }
    }
    Console.WriteLine($"O maior valor na matriz é {MaiorValor} e sua linha é {LinhaMaior} e coluna {ColunaMaior} ");