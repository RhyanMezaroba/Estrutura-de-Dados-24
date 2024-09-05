// JagueArray é o Array do Ceará
// JaggedArray é também conhecido como, um vetor de vetores (Cada casa do vetor vai haver outro vetor dentro dele)
int [][] numbers = new int [5][];
// neste caso [][], indica que é um vetor de vetor
// neste exemplo um vetor de 4 posições contendo vetores de tam. indefinido
numbers [0] = new int[]{1, 2, 3};
numbers [1] = new int[]{4, 3, 2, 1, 0};
numbers [2] = new int[]{1, 2, 0};
numbers [3] = new int[]{57};
numbers [4] = null!; //NULL deve receber ! = pode ser null ===> agora se for utilizado ? = Vai ser nulo

// Para obter valor de JaggedArray
int valor = numbers[0][2];
Console.WriteLine (valor);
// Para atribuir um valor em um JaggaedArray
numbers [1][2] = 0;
Console.WriteLine (numbers [1][2]);