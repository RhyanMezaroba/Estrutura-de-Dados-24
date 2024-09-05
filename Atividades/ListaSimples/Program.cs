using System.Collections;

// Utilizando a lista Simples
ArrayList arrList = new(); // pode ser utilizado *new ArrayList ()* ou *só new()* => menos caracteres
arrList.Add(5);
arrList.Add("Rhyan");
// É possível adicionar um conjunto de valores de uma só vez
arrList.AddRange(new int[]{1, 2, 3});
// o método .Add() insere o valor ao final do vetor
arrList.Insert(2, 15); // Parâmetro 2 incluindo o valor 15
// Já o método insert, me permite incluir o valor desejado na posição especificada no primeiro parâmetro
//Criando um novo espaço no vetor e empurrando todos os outros dados para frente...

//Lendo valores da lista 
object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

// Percorrendo a Lista com foreach
foreach(object obj in arrList)
{
    Console.Write($" | {obj}");
}

Console.WriteLine("");

//obtendo o tamanho total da lista
// Quantos elementos tem
int tamanho = arrList.Count;
// obter a capacidade
// Quantos podem ser armazenados
int capacidade = arrList.Capacity;

// Percorrendo no modo clássico
for(int i = 0; i < arrList.Count; i++)
{
    Console.Write($" | {arrList[i]}");
}

Console.WriteLine("");

// Recursos importantes da Lista verificar se um valor é contido na lista
bool contemNome = arrList.Contains("Rhyan");
    if(!contemNome) // Não precisa de {} pois à somente 1 instrução, mas apartir de 2 é necessário
        Console.WriteLine("Nome não encontrado!");
    

// Para Saber o índice que contém o valor buscado, neste caso se o valor existir na lista, ele retorna o índice (número inteiro)
// Caso NÃO exista na lista, retorna (-1)
int indiceDoValor = arrList.IndexOf("Rhyan");
if(indiceDoValor >= 0)
    Console.WriteLine($"Rhyan Está em [{indiceDoValor}]");
else
    Console.WriteLine("É, realmente não tem!");

// É possível também remover intes da lista
arrList.Remove("Rhyan"); //Remove pelo valor
arrList.RemoveAt(4);//Remove o pelo índice
arrList.RemoveRange(0, 2); // O 1° parâmetro é o ÍNDICE ==> O 2° quantas casas após o índice